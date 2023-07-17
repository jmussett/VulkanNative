using CSharpComposer;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Formatting;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Formatting;
using Microsoft.CodeAnalysis.MSBuild;
using Microsoft.CodeAnalysis.Simplification;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
using VulkanNative.Generator.Registry;

// TODO: clear project

var registryUrl = "https://raw.githubusercontent.com/KhronosGroup/Vulkan-Docs/main/xml/vk.xml";
using var httpClient = new HttpClient();

var registryXml = await httpClient.GetStringAsync(registryUrl);

var serializer = new XmlSerializer(typeof(VkRegistry));
using var reader = new StringReader(registryXml);
var registry = (VkRegistry)serializer.Deserialize(reader);

var workspace = MSBuildWorkspace.Create();

var project = await workspace.OpenProjectAsync("..\\..\\..\\..\\VulkanNative\\VulkanNative.csproj");

//GenerateCommandSyntax(workspace, project);

//return;

var documentRegistry = new Dictionary<string, CompilationUnitSyntax>();

var typeRegistry = new Dictionary<string, string>
{
    { "void", "void" },
    { "char", "char" },
    { "float", "float"},
    { "double", "double" },
    { "int8_t", "sbyte" },
    { "uint8_t", "byte" },
    { "int16_t", "short" },
    { "uint16_t", "ushort"},
    { "int32_t", "int" },
    { "uint32_t", "uint"},
    { "int64_t", "long" },
    { "uint64_t", "ulong"},
    { "size_t", "nint" }
};

var commandLookup = registry.Commands
    .Where(x => x.Api is null || x.Api == "vulkan")
    .Where(x => x.Alias is null) // TODO: manage aliases
    .ToDictionary(x => x.Proto.Name, x => x);

var enumTypeLookup = registry.Types
    .Where(x => x.Category == "enum")
    .Where(x => x.Alias is null) // TODO: manage aliases
    .ToDictionary(x => x.NameAttribute, x => x);

var structLookup = registry.Types
    .Where(x => x.Category == "struct")
    .Where(x => x.Alias is null) // TODO: manage aliases
    .ToDictionary(x => x.NameAttribute, x => x);

var handleLookup = registry.Types
    .Where(x => x.Category == "handle")
    .Where(x => x.Alias is null) // TODO: manage aliases
    .ToDictionary(x => x.Name, x => x);

var bitmaskLookup = registry.Types
    .Where(x => x.Category == "bitmask")
    .Where(x => x.Api is null || x.Api == "vulkan")
    .Where(x => x.Alias is null) // TODO: manage aliases
    .ToDictionary(x => x.Name, x => x);

var basetypeLookup = registry.Types
    .Where(x => x.Category == "basetype")
    .Where(x => x.Alias is null) // TODO: manage aliases
    .ToDictionary(x => x.Name, x => x);

var funcPointerLookup = registry.Types
    .Where(x => x.Category == "funcpointer")
    .ToDictionary(x => x.Name, x => x);

var unionTypeLookup = registry.Types
    .Where(x => x.Category == "union")
    .ToDictionary(x => x.NameAttribute, x => x);

var enumLookup = registry.Enums
    .ToDictionary(x => x.Name, x => x);

var globalCommands = new List<string>();
var instanceCommands = new List<string>();
var deviceCommands = new List<string>();

foreach (var require in registry.Feature.SelectMany(x => x.Requires))
{
    foreach (var command in require.Commands)
    {
        if (!commandLookup.TryGetValue(command.Name, out var commandDefinition))
        {
            throw new InvalidOperationException($"Unable to find command definition '{command.Name}'");
        }

        var firstParamType = commandDefinition.Params.FirstOrDefault()?.Type;
        var commandGroup = firstParamType != null ? GetCommandGroup(commandDefinition) : "Global";

        switch (commandGroup)
        {
            case "Global":
                globalCommands.Add(command.Name);
                break;
            case "Instance":
                instanceCommands.Add(command.Name);
                break;
            case "Device":
                deviceCommands.Add(command.Name);
                break;
        }
    }
}


var compilationUnit = CSharpFactory.CompilationUnit(x => x
    .AddFileScopedNamespaceDeclaration("VulkanNative", x => x
        .AddClassDeclaration("VkGlobalCommands", x =>
        {
            x = x
                .AddModifierToken(SyntaxKind.PublicKeyword)
                .AddModifierToken(SyntaxKind.UnsafeKeyword);

            foreach (var commandName in globalCommands)
            {
                x = AddCommandToClass(x, commandName, commandLookup);
            }
        })
    ));

documentRegistry.Add("Commands/VkGlobalCommands.cs", compilationUnit);

compilationUnit = CSharpFactory.CompilationUnit(x => x
    .AddFileScopedNamespaceDeclaration("VulkanNative", x => x
        .AddClassDeclaration("VkInstanceCommands", x =>
        {
            x = x
                .AddModifierToken(SyntaxKind.PublicKeyword)
                .AddModifierToken(SyntaxKind.UnsafeKeyword);

            foreach (var commandName in instanceCommands)
            {
                x = AddCommandToClass(x, commandName, commandLookup);
            }
        })
    ));

documentRegistry.Add("Commands/VkInstanceCommands.cs", compilationUnit);

compilationUnit = CSharpFactory.CompilationUnit(x => x
    .AddFileScopedNamespaceDeclaration("VulkanNative", x => x
        .AddClassDeclaration("VkDeviceCommands", x =>
        {
            x = x
                .AddModifierToken(SyntaxKind.PublicKeyword)
                .AddModifierToken(SyntaxKind.UnsafeKeyword);

            foreach (var commandName in deviceCommands)
            {
                x = AddCommandToClass(x, commandName, commandLookup);
            }
        })
    ));

documentRegistry.Add("Commands/VkDeviceCommands.cs", compilationUnit);

foreach(var documentEntry in documentRegistry)
{
    var documentName = documentEntry.Key;
    compilationUnit = documentEntry.Value;

    //compilationUnit = SimplifierAnnotator.Annotate(compilationUnit);

    var document = project.AddDocument(documentName, compilationUnit);

    var formattedDocument = await Formatter.FormatAsync(document);
    var formattedText = await formattedDocument.GetTextAsync();

    var updatedDocument = formattedDocument.Project
        .GetDocument(formattedDocument.Id)
        .WithText(formattedText);

    //var simplifiedDocument = await Simplifier.ReduceAsync(updatedDocument);

    project = updatedDocument.Project;
}


workspace.TryApplyChanges(project.Solution);

void LookupReturnType(ITypeBuilder typeBuilder, string type, string? postTypeData = null)
{
    if (type == "void")
    {
        if (string.IsNullOrEmpty(postTypeData))
        {
            typeBuilder.AsPredefinedType(PredefinedTypeKeyword.VoidKeyword);
        }
    }

    LookupType(typeBuilder, type, postTypeData);
}

void BuildPointerType(ITypeBuilder typeBuilder, string typeName, int pointerRank)
{
    if (pointerRank == 0)
    {
        LookupType(typeBuilder, typeName, null);
    }
    else
    {
        typeBuilder.AsPointerType(x => BuildPointerType(x, typeName, pointerRank - 1));
    }
}

void LookupType(ITypeBuilder typeBuilder, string type, string? postTypeData = null)
{
    var pointerRank = postTypeData?.Count(c => c == '*') ?? 0;

    if (pointerRank > 0)
    {
        BuildPointerType(typeBuilder, type, pointerRank);
        return;
    }

    if (typeRegistry.TryGetValue(type, out var typeName))
    {
        typeBuilder.ParseTypeName(typeName);
        return;
    }

    if (structLookup.TryGetValue(type, out var structDefinition))
    {
        var structName = structDefinition.NameAttribute;

        documentRegistry.Add($"Structs/{structName}.cs", CSharpFactory.CompilationUnit(x => x
            .AddUsingDirective("System.Runtime.InteropServices")
            .AddFileScopedNamespaceDeclaration("VulkanNative", x =>
                x.AddStructDeclaration(structName, x => {
                    x = x
                        .AddModifierToken(SyntaxKind.PublicKeyword)
                        .AddModifierToken(SyntaxKind.UnsafeKeyword)
                        .AddAttribute("StructLayout", x => x.AddAttributeArgument("LayoutKind.Sequential"));

                    // returnedonly ?? -> readonly
                    // structextends ?? indicates that struct extends the "structextends" struct. Maybe not necessary for initial code gen.

                    foreach (var fieldDefinition in structDefinition.Members)
                    {
                        // platform specific?
                        // optional?
                        // array?

                        if (!string.IsNullOrEmpty(fieldDefinition.Api) && fieldDefinition.Api != "vulkan")
                        {
                            // Skip when the field is not part of the standard vulkan api (i.e: vulkansc)
                            continue;
                        }

                        x = x.AddFieldDeclaration(
                            x => LookupType(x, fieldDefinition.Type, fieldDefinition.PostTypeText),
                            x => x.AddVariableDeclarator(fieldDefinition.Name),
                            x => x.AddModifierToken(SyntaxKind.PublicKeyword)
                        );
                    }
                })
            )
        ));

        typeRegistry.TryAdd(structName, structName);

        typeBuilder.ParseTypeName(structName);

        return;
    }

    if (handleLookup.TryGetValue(type, out var handleDefinition))
    {
        var handleName  = handleDefinition.Name;

        documentRegistry.Add($"Handles/{handleName}.cs", CSharpFactory.CompilationUnit(x => x
            .AddUsingDirective("System.Runtime.InteropServices")
            .AddFileScopedNamespaceDeclaration("VulkanNative", x =>
                x.AddStructDeclaration(handleName, x => x
                    .AddModifierToken(SyntaxKind.PublicKeyword)
                    .AddModifierToken(SyntaxKind.ReadOnlyKeyword)
                    .AddAttribute("StructLayout", x => x.AddAttributeArgument("LayoutKind.Sequential")) //TODO add extension for literal arguments 
                    .AddFieldDeclaration("nint", 
                        x => x.AddVariableDeclarator("_handle"), 
                        x => x
                            .AddModifierToken(SyntaxKind.PrivateKeyword)
                            .AddModifierToken(SyntaxKind.ReadOnlyKeyword)
                    )
                    .AddConstructorDeclaration(handleName, x => x
                        .AddParameter("handle", x => x.WithType("nint"))
                        .AddModifierToken(SyntaxKind.PublicKeyword)
                        .WithBody(x => x
                            .AddExpressionStatement(x => x
                                .AsAssignmentExpression(
                                    AssignmentExpressionKind.SimpleAssignmentExpression,
                                    x => x.AsIdentifierName("_handle"),
                                    x => x.AsIdentifierName("handle")
                                )
                            )
                        )
                    )
                    .AddMemberDeclaration(x => x
                        .AsConversionOperatorDeclaration(
                            ConversionOperatorDeclarationImplicitOrExplicitKeyword.ImplicitKeyword, 
                            x => x.ParseTypeName(handleName),
                            x => x
                                .AddModifierToken(SyntaxKind.PublicKeyword)
                                .AddModifierToken(SyntaxKind.StaticKeyword)
                                .AddParameter("handle", x => x.WithType("nint"))
                                .WithBody(x => x
                                    .AddReturnStatement(
                                        x => x.WithExpression($"new {handleName}(handle)")
                                    )
                                )
                        )
                    )
                    .AddMemberDeclaration(x => x
                        .AsConversionOperatorDeclaration(
                            ConversionOperatorDeclarationImplicitOrExplicitKeyword.ImplicitKeyword,
                            x => x.ParseTypeName("nint"),
                            x => x
                                .AddModifierToken(SyntaxKind.PublicKeyword)
                                .AddModifierToken(SyntaxKind.StaticKeyword)
                                .AddParameter("value", x => x.WithType(handleName))
                                .WithBody(x => x
                                    .AddReturnStatement(
                                        x => x.WithExpression($"value._handle")
                                    )
                                )
                        )
                    )
                )
            )
        ));

        typeRegistry.TryAdd(handleName, handleName);

        typeBuilder.ParseTypeName(handleName);

        return;
    }

    if (enumTypeLookup.TryGetValue(type, out var enumTypeDefinition))
    {
        /*
        - enum types with a bitwidth of 32 (or no bitwidth) will be int32_t, or an 'int' in c#
        - enum types with a bitwidth of 64 will be int64_t, or a 'long' in c#
        - bitmask types with a bitwidth of 32 (or no bitwidth) will be uint32_t, or a 'uint' in c#
        - bitmask types with a bitwidth of 64 will be uint64_t, or a 'ulong' in c#
        */

        var enumName = enumTypeDefinition.NameAttribute;

        if (!enumLookup.TryGetValue(enumName, out var enumDefinition))
        {
            throw new InvalidOperationException($"Unable to find enum '{enumName}'");
        }

        var enumType = enumDefinition.Type switch
        {
            "enum" => "int",
            "bitmask" => enumDefinition.BitWidth == "64" ? "ulong" : "uint",
            _ => throw new InvalidOperationException()
        };

        documentRegistry.Add($"Enums/{enumName}.cs", CSharpFactory.CompilationUnit(x => x
            .AddFileScopedNamespaceDeclaration("VulkanNative", x =>
                x.AddEnumDeclaration(
                    enumName,
                    x =>
                    {
                        x.AddSimpleBaseType(enumType);
                        x.AddModifierToken(SyntaxKind.PublicKeyword);

                        if (enumDefinition.Type == "bitmask")
                        {
                            x = x.AddAttribute("Flags");
                        }

                        foreach(var enumMember in enumDefinition.Enums)
                        {
                            // TODO: comments

                            var enumValue = enumMember.Value is not null
                                ? enumMember.Value
                                : enumMember.Bitpos;

                            x = enumValue is not null 
                                ? x.AddEnumMemberDeclaration(enumMember.Name, x => x.WithEqualsValue(enumValue))
                                : x.AddEnumMemberDeclaration(enumMember.Name);
                        }
                    }
                )
            )
        ));

        typeRegistry.TryAdd(enumName, enumName);

        typeBuilder.ParseTypeName(enumName);

        return;
    }

    if (bitmaskLookup.TryGetValue(type, out var bitmaskTypeDefinition))
    {
        //var bitmaskUnderlyingType = LookupType(bitmaskTypeDefinition.Type);

        var bitmaskName = bitmaskTypeDefinition.Name;

        documentRegistry.Add($"Bitmasks/{bitmaskName}.cs", CSharpFactory.CompilationUnit(x =>
            x.AddFileScopedNamespaceDeclaration("VulkanNative", x =>
                x.AddStructDeclaration(bitmaskName, x => x.AddModifierToken(SyntaxKind.PublicKeyword)
                //.WithBaseType(x => x.AsType(bitmaskUnderlyingType))
                ) // TODO: Add fields.
            )
        ));

        typeRegistry.TryAdd(bitmaskName, bitmaskName);

        typeBuilder.ParseTypeName(bitmaskName);

        return;
    }

    if (basetypeLookup.TryGetValue(type, out var baseTypeDefinition))
    {
        // TODO: Add Underlying Type

        var baseTypeName = baseTypeDefinition.Name;

        documentRegistry.Add($"BaseTypes/{baseTypeName}.cs", CSharpFactory.CompilationUnit(x =>
            x.AddFileScopedNamespaceDeclaration("VulkanNative", x =>
                x.AddStructDeclaration(baseTypeName, x => x.AddModifierToken(SyntaxKind.PublicKeyword)) // TODO: Add fields.
            )
        ));

        typeRegistry.TryAdd(baseTypeName, baseTypeName);

        typeBuilder.ParseTypeName(baseTypeName);

        return;
    }

    if (funcPointerLookup.TryGetValue(type, out var funcPointerDefinition))
    {
        // TODO: Add Underlying Type

        documentRegistry.Add($"Functions/{funcPointerDefinition.Name}.cs", CSharpFactory.CompilationUnit(x =>
            x.AddFileScopedNamespaceDeclaration("VulkanNative", x =>
                x.AddStructDeclaration(funcPointerDefinition.Name, x => x.AddModifierToken(SyntaxKind.PublicKeyword)) // TODO: Add fields.
            )
        ));

        typeRegistry.TryAdd(funcPointerDefinition.Name, funcPointerDefinition.Name);

        typeBuilder.ParseTypeName(funcPointerDefinition.Name);

        return;
    }

    if (unionTypeLookup.TryGetValue(type, out var unionTypeDefinition))
    {
        // TODO: Add Underlying Type

        documentRegistry.Add($"Unions/{unionTypeDefinition.NameAttribute}.cs", CSharpFactory.CompilationUnit(x =>
            x.AddFileScopedNamespaceDeclaration("VulkanNative", x =>
                x.AddStructDeclaration(unionTypeDefinition.NameAttribute, x => x.AddModifierToken(SyntaxKind.PublicKeyword)) // TODO: Add fields.
            )
        ));

        typeRegistry.TryAdd(unionTypeDefinition.NameAttribute, unionTypeDefinition.NameAttribute);

        typeBuilder.ParseTypeName(unionTypeDefinition.NameAttribute);

        return;
    }

    throw new Exception($"Type '{type}' cannot be found.");
}

IClassDeclarationBuilder AddCommandToClass(IClassDeclarationBuilder classBuilder, string commandName, Dictionary<string, VkCommand> commandLookup)
{
    var commandDefinition = commandLookup[commandName];

    
    return classBuilder.AddFieldDeclaration(
        x => x.AsFunctionPointerType(x =>
        {
            x.WithCallingConvention(
                FunctionPointerCallingConventionManagedOrUnmanagedKeyword.UnmanagedKeyword,
                x => x.AddFunctionPointerUnmanagedCallingConvention("Cdecl")
            );

            foreach (var param in commandDefinition.Params)
            {
                x.AddFunctionPointerParameter(
                    x => LookupType(x, param.Type, param.PostTypeText)
                );
            }

            x.AddFunctionPointerParameter(
                x => LookupReturnType(x, commandDefinition.Proto.Type)
            );
        }),
        x => x.AddVariableDeclarator(commandName),
        x => x.AddModifierToken(SyntaxKind.PublicKeyword)
    );
}

bool IsHandleInheritsFrom(string handleType, string parentType)
{
    var current = handleType;
    while (current is not null && handleLookup.TryGetValue(current, out var handle))
    {
        if (handle.Name == parentType || handle.Parent == parentType)
            return true;

        current = handle.Parent;
    }
    return false;
}

string GetCommandGroup(VkCommand commandDefinition)
{
    var functionName = commandDefinition.Proto.Name;
    var firstParamType = commandDefinition.Params.FirstOrDefault()?.Type;

    if (functionName == "vkGetDeviceProcAddr" || functionName == "vkGetInstanceProcAddr" || firstParamType is null)
    {
        return "Global";
    }

    if (IsHandleInheritsFrom(firstParamType, "VkDevice"))
    {
        return "Device";
    }

    if (IsHandleInheritsFrom(firstParamType, "VkInstance"))
    {
        return "Instance";
    }

    return "Global";
}

//public class SimplifierAnnotator : CSharpSyntaxRewriter
//{
//    public static T Annotate<T>(T syntax) where T : SyntaxNode
//    {
//        var annotator = new SimplifierAnnotator();

//        return (T)annotator.Visit(syntax);
//    }

//    public override SyntaxNode? Visit(SyntaxNode node)
//    {
//        If the node is a using directive or a qualified name, add the Simplifier.Annotation
//        if (node is not UsingDirectiveSyntax)
//        {
//            return base.Visit(node)?.WithAdditionalAnnotations(Simplifier.Annotation);
//        }

//        For all other nodes, visit them without adding the Simplifier.Annotation
//        return base.Visit(node);

//    }
//}

//static void GenerateCommandSyntax(MSBuildWorkspace workspace, Project project)
//{
//    var document = project.AddDocument("Test.cs", CompilationUnitBuilder.CreateSyntax(x => x
//        .AddFileScopedNamespaceDeclaration(x => x.ParseName("Test.Test"), x => x
//            .WithEnum("TestEnum", x => x
//                .WithAccessModifier(TypeAccessModifier.Public)
//                .WithMember("A", 1)
//            )
//            .WithEnum<byte>("TestEnumByte", x => x
//                .WithAccessModifier(TypeAccessModifier.Public)
//                .WithMember("A", 1)
//            )
//            .WithClass("TestClass", x => x
//                .WithAccessModifier(TypeAccessModifier.Public)
//                .WithAttribute("ObsoleteAttribute")
//                .WithConstructor()
//                .WithProperty<string>("Property1")
//                .WithField<string>("_field1")
//                .WithField<DateTime>("_date")
//                //.WithField("test", x => x
//                //.AsGeneric(typeof(List<>), x => x.WithTypeArgument<string>())
//                //)
//                .WithMethod("HelloWorld", x => x
//                    .WithAccessModifier(MemberAccessModifier.Public)
//                    .WithParameter("text", "int")
//                    .WithTypeParameter("T", x => x.WithNotNullConstraint())
//                    .WithBody(x => x
//                        .WithLocalFunction(
//                            "MyLocalFunction",
//                            x => x.WithParameter<short>("a")
//                            //x => x.WithLocalDeclaration<int>("a", 5)
//                        )
//                        .WithIfStatement(
//                            x => x.AsLiteral(true),
//                            x => x.WithLocalDeclaration("b", 2),
//                            x => x.WithElseIf(
//                                x => x.AsLiteral(false),
//                                x => x.WithLocalDeclaration("d", 6),
//                                x => x.WithElse(x => x.WithLocalDeclaration("c", 5))
//                            )
//                        )
//                        .WithForStatement(x => x
//                            .WithDeclaration("i", 0)
//                            .WithDeclaration("j", 1)
//                            .WithBody(x =>
//                                x.WithLocalDeclaration("k", 10)
//                            )
//                        )
//                    )
//                )
//            )
//            .WithStruct("TestStruct", x => x)
//            .WithInterface("TestInterface", x => x
//                .WithTypeParameter("T", VarianceModifier.In)
//                .WithMethod<string>("TestMethod", x => x
//                    .WithParameter<string>("a")
//                    .WithParameter<int>("b")
//                )
//            )
//        // TODO: rethink type level access modifiers for delegates
//        //.WithDelegate("TestDelegate", x => x
//        //.WithAccessModifier(MemberAccessModifier.Public)
//        //.WithParameter<string>("text")
//        //)
//        )
//    ));

//    workspace.TryApplyChanges(document.Project.Solution);
//}

[Flags]
public enum VkShaderStageFlagBits : uint
{
    VK_SHADER_STAGE_VERTEX_BIT = 1 << 0,
    VK_SHADER_STAGE_TESSELLATION_CONTROL_BIT = 1 << 1,
    VK_SHADER_STAGE_TESSELLATION_EVALUATION_BIT = 1 << 2,
    VK_SHADER_STAGE_GEOMETRY_BIT = 1 << 3,
    VK_SHADER_STAGE_FRAGMENT_BIT = 1 << 4,
    VK_SHADER_STAGE_COMPUTE_BIT = 1 << 5,
    VK_SHADER_STAGE_ALL_GRAPHICS = 0x0000001F,
    VK_SHADER_STAGE_ALL = 0x7FFFFFFF
}