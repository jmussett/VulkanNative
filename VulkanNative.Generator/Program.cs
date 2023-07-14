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
using VulkanNative.Generator.Builder;
using VulkanNative.Generator.Builder.Builders;
using VulkanNative.Generator.Builder.Types;
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


var compilationUnit = CompilationUnitBuilder.CreateSyntax(x => x
    .WithFileScopedNamespace("VulkanNative", x => x
        .WithClass("VkGlobalCommands", x =>
        {
            x = x
                .WithAccessModifier(TypeAccessModifier.Public)
                .WithUnsafeModifier();

            foreach (var commandName in globalCommands)
            {
                x = AddCommandToClass(x, commandName, commandLookup);
            }
            return x;
        })
    ));

documentRegistry.Add("Commands/VkGlobalCommands.cs", compilationUnit);

compilationUnit = CompilationUnitBuilder.CreateSyntax(x => x
    .WithFileScopedNamespace("VulkanNative", x => x
        .WithClass("VkInstanceCommands", x =>
        {
            x = x
                .WithAccessModifier(TypeAccessModifier.Public)
                .WithUnsafeModifier();

            foreach (var commandName in instanceCommands)
            {
                x = AddCommandToClass(x, commandName, commandLookup);
            }

            return x;
        })
    ));

documentRegistry.Add("Commands/VkInstanceCommands.cs", compilationUnit);

compilationUnit = CompilationUnitBuilder.CreateSyntax(x => x
    .WithFileScopedNamespace("VulkanNative", x => x
        .WithClass("VkDeviceCommands", x =>
        {
            x = x
                .WithAccessModifier(TypeAccessModifier.Public)
                .WithUnsafeModifier();

            foreach (var commandName in deviceCommands)
            {
                x = AddCommandToClass(x, commandName, commandLookup);
            }

            return x;
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

ITypeBuilder LookupReturnType(ITypeBuilder typeBuilder, string type, string? postTypeData = null)
{
    if (type == "void")
    {
        if (string.IsNullOrEmpty(postTypeData))
        {
            return typeBuilder.AsVoid();
        }
    }

    return LookupType(typeBuilder, type, postTypeData);
}

T BuildPointerType<T>(T typeBuilder, string typeName, int pointerRank) where T : ITypeBuilder<T>
{
    if (pointerRank == 0)
    {
        return LookupType<T>(typeBuilder, typeName, null);
    }
    else
    {
        return typeBuilder.AsPointer(x => BuildPointerType(x, typeName, pointerRank - 1));
    }
}

T LookupType<T>(T typeBuilder, string type, string? postTypeData = null) where T : ITypeBuilder<T>
{
    var pointerRank = postTypeData?.Count(c => c == '*') ?? 0;

    if (pointerRank > 0)
    {
        return BuildPointerType(typeBuilder, type, pointerRank);
    }

    if (typeRegistry.TryGetValue(type, out var typeName))
    {
        return typeBuilder.AsType(typeName);
    }

    if (structLookup.TryGetValue(type, out var structDefinition))
    {
        var structName = structDefinition.NameAttribute;

        documentRegistry.Add($"Structs/{structName}.cs", CompilationUnitBuilder.CreateSyntax(x => x
            .WithUsing("System.Runtime.InteropServices")
            .WithFileScopedNamespace("VulkanNative", x =>
                x.WithStruct(structName, x => {
                    x = x.WithAccessModifier(TypeAccessModifier.Public)
                        .WithAttribute<StructLayoutAttribute>(x => x.WithArgument(LayoutKind.Sequential))
                        .WithUnsafeModifier();

                    // returnedonly ?? -> readonly
                    // structextends ?? indicates that struct extends the "structextends" struct. Maybe not necessary for initial code gen.

                    foreach (var fieldDefinition in structDefinition.Members)
                    {
                        // platform specific?
                        // optional?
                        // array?

                        x = x.WithField(
                            fieldDefinition.Name,
                            x => LookupType(x, fieldDefinition.Type, fieldDefinition.PostTypeText),
                            x => x
                                .WithAccessModifier(MemberAccessModifier.Public)
                        );
                        

                    }

                    return x;
                })
            )
        ));

        typeRegistry.TryAdd(structName, structName);

        return typeBuilder.AsType(structName);
    }

    if (handleLookup.TryGetValue(type, out var handleDefinition))
    {
        var handleName  = handleDefinition.Name;

        documentRegistry.Add($"Handles/{handleName}.cs", CompilationUnitBuilder.CreateSyntax(x => x
            .WithUsing("System.Runtime.InteropServices")
            .WithFileScopedNamespace("VulkanNative", x =>
                x.WithStruct(handleName, x => x
                    .WithAccessModifier(TypeAccessModifier.Public)
                    .WithReadOnlyModifier()
                    .WithAttribute<StructLayoutAttribute>(x => x.WithArgument(LayoutKind.Sequential)) //TODO add extension for literal arguments
                    .WithField<nint>("_handle", x => x
                        .WithAccessModifier(MemberAccessModifier.Private)
                        .WithReadOnlyModifier()
                    )
                    .WithConstructor(x => x
                        .WithParameter<nint>("handle")
                        .WithAccessModifier(MemberAccessModifier.Public)
                        .WithBody(x => x
                            .WithExpression(x => x.AsAssignment(
                                x => x.AsName("_handle"),
                                AssignmentType.Equal, 
                                x => x.AsName("handle")
                            )) // TODO: Create extensions
                        ) 
                    )
                    // TODO: operator extensions
                    .WithConversionOperator(ConversionOperatorType.Implicit, x => x.AsType(handleName), x => x
                        .WithParameter<nint>("handle")
                        .WithBody(x => 
                            x.WithReturnStatement(x => 
                                x.AsNew(x => 
                                    x.AsType(handleName), 
                                    x => x.WithArgument(x => x.AsName("handle"))
                                ) // TODO: ImplicitObjectCreation + Create Extensions
                            )
                        )
                    )
                    .WithConversionOperator(ConversionOperatorType.Implicit, x => x.AsType<nint>(), x => x
                        .WithParameter("value", x => x.AsType(handleName))
                        .WithBody(x => x
                            .WithReturnStatement(x => x
                                .AsMemberAccess(
                                    x => x.AsName("value"), 
                                    x => x.AsIdentifier("_handle")
                                ) // TODO: Create Extensions
                            ) 
                        )
                    )
                )
            )
        ));

        typeRegistry.TryAdd(handleName, handleName);

        return typeBuilder.AsType(handleName);
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

        Type enumType = enumDefinition.Type switch
        {
            "enum" => typeof(int),
            "bitmask" => enumDefinition.BitWidth == "64" ? typeof(ulong) : typeof(uint),
            _ => throw new InvalidOperationException()
        };

        documentRegistry.Add($"Enums/{enumName}.cs", CompilationUnitBuilder.CreateSyntax(x => x
            .WithFileScopedNamespace("VulkanNative", x =>
                x.WithEnum(
                    enumName,
                    x =>
                    {
                        x = x.WithAccessModifier(TypeAccessModifier.Public);

                        if (enumDefinition.Type == "bitmask")
                        {
                            x = x.WithAttribute(typeof(FlagsAttribute));
                        }

                        foreach(var enumMember in enumDefinition.Enums)
                        {
                            // TODO: comments

                            var enumValue = enumMember.Value is not null
                                ? enumMember.Value
                                : enumMember.Bitpos;

                            x = enumValue is not null 
                                ? x.WithMember(enumMember.Name, x => x.ParseExpression(enumValue)) 
                                : x.WithMember(enumMember.Name);
                        }

                        return x;
                    },
                    x => x.AsType(enumType) // TODO: extension
                ) // TODO: Add fields.
            )
        ));

        typeRegistry.TryAdd(enumName, enumName);

        return typeBuilder.AsType(enumName);
    }

    if (bitmaskLookup.TryGetValue(type, out var bitmaskTypeDefinition))
    {
        //var bitmaskUnderlyingType = LookupType(bitmaskTypeDefinition.Type);

        var bitmaskName = bitmaskTypeDefinition.Name;

        documentRegistry.Add($"Bitmasks/{bitmaskName}.cs", CompilationUnitBuilder.CreateSyntax(x =>
            x.WithFileScopedNamespace("VulkanNative", x =>
                x.WithStruct(bitmaskName, x => x.WithAccessModifier(TypeAccessModifier.Public)
                //.WithBaseType(x => x.AsType(bitmaskUnderlyingType))
                ) // TODO: Add fields.
            )
        ));

        typeRegistry.TryAdd(bitmaskName, bitmaskName);

        return typeBuilder.AsType(bitmaskName);
    }

    if (basetypeLookup.TryGetValue(type, out var baseTypeDefinition))
    {
        // TODO: Add Underlying Type

        var baseTypeName = baseTypeDefinition.Name;

        documentRegistry.Add($"BaseTypes/{baseTypeName}.cs", CompilationUnitBuilder.CreateSyntax(x =>
            x.WithFileScopedNamespace("VulkanNative", x =>
                x.WithStruct(baseTypeName, x => x.WithAccessModifier(TypeAccessModifier.Public)) // TODO: Add fields.
            )
        ));

        typeRegistry.TryAdd(baseTypeName, baseTypeName);

        return typeBuilder.AsType(baseTypeName);
    }

    if (funcPointerLookup.TryGetValue(type, out var funcPointerDefinition))
    {
        // TODO: Add Underlying Type

        documentRegistry.Add($"Functions/{funcPointerDefinition.Name}.cs", CompilationUnitBuilder.CreateSyntax(x =>
            x.WithFileScopedNamespace("VulkanNative", x =>
                x.WithStruct(funcPointerDefinition.Name, x => x.WithAccessModifier(TypeAccessModifier.Public)) // TODO: Add fields.
            )
        ));

        typeRegistry.TryAdd(funcPointerDefinition.Name, funcPointerDefinition.Name);

        return typeBuilder.AsType(funcPointerDefinition.Name);
    }

    if (unionTypeLookup.TryGetValue(type, out var unionTypeDefinition))
    {
        // TODO: Add Underlying Type

        documentRegistry.Add($"Unions/{unionTypeDefinition.NameAttribute}.cs", CompilationUnitBuilder.CreateSyntax(x =>
            x.WithFileScopedNamespace("VulkanNative", x =>
                x.WithStruct(unionTypeDefinition.NameAttribute, x => x.WithAccessModifier(TypeAccessModifier.Public)) // TODO: Add fields.
            )
        ));

        typeRegistry.TryAdd(unionTypeDefinition.NameAttribute, unionTypeDefinition.NameAttribute);

        return typeBuilder.AsType(unionTypeDefinition.NameAttribute);
    }

    throw new Exception($"Type '{type}' cannot be found.");
}

IClassDeclarationBuilder AddCommandToClass(IClassDeclarationBuilder classBuilder, string commandName, Dictionary<string, VkCommand> commandLookup)
{
    var commandDefinition = commandLookup[commandName];

    return classBuilder.WithField(
        commandName,
        x => x
            .AsFunctionPointer(x =>
            {
                x = x.AsUnmanaged(VulkanNative.Generator.Builder.Types.CallingConvention.Cdecl); // TODO: Change type name

                foreach (var param in commandDefinition.Params)
                {
                    x.WithParameter(x => LookupType(x, param.Type, param.PostTypeText));
                }

                x.WithReturn(x => LookupReturnType(x, commandDefinition.Proto.Type));

                return x;
            }),
        x => x.WithAccessModifier(MemberAccessModifier.Public)
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
//        .WithFileScopedNamespace(x => x.ParseName("Test.Test"), x => x
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