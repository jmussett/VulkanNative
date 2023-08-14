using Microsoft.CodeAnalysis.Formatting;
using Microsoft.CodeAnalysis.MSBuild;
using System.Xml.Serialization;
using VulkanNative.Generator;
using VulkanNative.Generator.Generators;
using VulkanNative.Generator.Registries;
using VulkanNative.Generator.Registry;
using VulkanNative.Generator.SyntaxGenerators;

// TODO: clear project

var registryUrl = "https://raw.githubusercontent.com/KhronosGroup/Vulkan-Docs/main/xml/vk.xml";
using var httpClient = new HttpClient();

var registryXml = await httpClient.GetStringAsync(registryUrl);

var serializer = new XmlSerializer(typeof(VkRegistry));
using var reader = new StringReader(registryXml);
var vkRegistry = (VkRegistry)serializer.Deserialize(reader);

var workspace = MSBuildWorkspace.Create();

var project = await workspace.OpenProjectAsync("..\\..\\..\\..\\VulkanNative\\VulkanNative.csproj");

var documentRegistry = new DocumentRegistry();
var typeRegistry = new TypeRegistry();
var generatorRegistry = new TypeGeneratorRegistry();
var enumRegistry = new EnumRegistry();

var typeLocator = new TypeLocator(vkRegistry, typeRegistry, generatorRegistry);

generatorRegistry.RegisterGenerator("struct", new StructTypeGenerator(documentRegistry, typeLocator));
generatorRegistry.RegisterGenerator("handle", new HandleTypeGenerator(documentRegistry));
generatorRegistry.RegisterGenerator("enum", new EnumTypeGenerator(enumRegistry, vkRegistry));
generatorRegistry.RegisterGenerator("basetype", new BaseTypeGenerator(documentRegistry, typeLocator));
generatorRegistry.RegisterGenerator("funcpointer", new FuncPointerGenerator(typeLocator));
generatorRegistry.RegisterGenerator("union", new UnionTypeGenerator(typeLocator, documentRegistry));
generatorRegistry.RegisterGenerator("bitmask", new BitMaskTypeGenerator(typeLocator, documentRegistry));

var commandGenerator = new CommandGenerator(vkRegistry, typeLocator);

var commandGroupGenerator = new CommandGroupGenerator(documentRegistry, commandGenerator);
var featureGenerator = new FeatureGenerator(vkRegistry, commandGroupGenerator, typeLocator, enumRegistry);
var extensionGenerator = new ExtensionGenerator(vkRegistry, commandGroupGenerator, typeLocator, enumRegistry);
var apiConstantsGenerator = new ApiConstantsGenerator(vkRegistry, documentRegistry, typeLocator);
var enumGenerator = new EnumGenerator(enumRegistry, documentRegistry);

apiConstantsGenerator.GenerateApiConstants();
featureGenerator.GenerateFeatures();
extensionGenerator.GenerateExtensions();
enumGenerator.GenerateEnums();

foreach(var documentEntry in documentRegistry.Documents)
{
    var documentName = documentEntry.Key;
    var compilationUnit = documentEntry.Value;

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