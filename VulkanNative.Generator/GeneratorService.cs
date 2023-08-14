using Microsoft.Extensions.Hosting;
using Microsoft.CodeAnalysis.MSBuild;
using Microsoft.CodeAnalysis.Formatting;
using VulkanNative.Generator.Generators;
using VulkanNative.Generator.SyntaxGenerators;
using VulkanNative.Generator.Registries;
using VulkanNative.Generator.VulkanRegistry;

namespace VulkanNative.Generator;

internal class GeneratorService : BackgroundService
{
    private readonly VulkanApiRegistry _vulkanApiRegistry;
    private readonly TypeGeneratorRegistry _generatorRegistry;
    private readonly DocumentRegistry _documentRegistry;
    private readonly ApiConstantsGenerator _apiConstantsGenerator;
    private readonly FeatureGenerator _featureGenerator;
    private readonly ExtensionGenerator _extensionGenerator;
    private readonly EnumGenerator _enumGenerator;

    private readonly IHostApplicationLifetime _lifetime;

    public GeneratorService(VulkanApiRegistry vulkanApiRegistry, TypeGeneratorRegistry generatorRegistry, DocumentRegistry documentRegistry, ApiConstantsGenerator apiConstantsGenerator, FeatureGenerator featureGenerator, ExtensionGenerator extensionGenerator, EnumGenerator enumGenerator, IHostApplicationLifetime lifetime)
    {
        _vulkanApiRegistry = vulkanApiRegistry;
        _generatorRegistry = generatorRegistry;
        _documentRegistry = documentRegistry;
        _apiConstantsGenerator = apiConstantsGenerator;
        _featureGenerator = featureGenerator;
        _extensionGenerator = extensionGenerator;
        _enumGenerator = enumGenerator;
        _lifetime = lifetime;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        try
        {
            await _vulkanApiRegistry.FetchApiRegistry();

            var workspace = MSBuildWorkspace.Create();

            var project = await workspace.OpenProjectAsync("..\\..\\..\\..\\VulkanNative\\VulkanNative.csproj");

            _generatorRegistry.RegisterGenerator<StructTypeGenerator>("struct");
            _generatorRegistry.RegisterGenerator<HandleTypeGenerator>("handle");
            _generatorRegistry.RegisterGenerator<EnumTypeGenerator>("enum");
            _generatorRegistry.RegisterGenerator<BaseTypeGenerator>("basetype");
            _generatorRegistry.RegisterGenerator<FuncPointerGenerator>("funcpointer");
            _generatorRegistry.RegisterGenerator<UnionTypeGenerator>("union");
            _generatorRegistry.RegisterGenerator<BitMaskTypeGenerator>("bitmask");

            Console.WriteLine("Generating C#...");

            _apiConstantsGenerator.GenerateApiConstants();
            _featureGenerator.GenerateFeatures();
            _extensionGenerator.GenerateExtensions();
            _enumGenerator.GenerateEnums();

            foreach (var documentEntry in _documentRegistry.Documents)
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

            Console.WriteLine("Applying changes...");

            workspace.TryApplyChanges(project.Solution);

            Console.WriteLine("Generation complete.");

            _lifetime.StopApplication();
        }
        catch(Exception e)
        {
            Console.WriteLine(e);

            throw;
        }
    }
}
