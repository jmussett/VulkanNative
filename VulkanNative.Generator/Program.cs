using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using VulkanNative.Generator;
using VulkanNative.Generator.Generators;
using VulkanNative.Generator.Registries;
using VulkanNative.Generator.SyntaxGenerators;
using VulkanNative.Generator.VulkanRegistry;

var builder = Host.CreateApplicationBuilder(args);

builder.Logging.ClearProviders();

builder.Services
    .AddSingleton<DocumentRegistry>()
    .AddSingleton<TypeRegistry>()
    .AddSingleton<TypeGeneratorRegistry>()
    .AddSingleton<EnumRegistry>()
    .AddSingleton<VulkanApiRegistry>()
    .AddTransient<TypeLocator>()
    .AddTransient<CommandGenerator>()
    .AddTransient<CommandGroupGenerator>()
    .AddTransient<FeatureGenerator>()
    .AddTransient<FeatureGenerator>()
    .AddTransient<ExtensionGenerator>()
    .AddTransient<ApiConstantsGenerator>()
    .AddTransient<EnumGenerator>()
    .AddTransient<StructTypeGenerator>()
    .AddTransient<HandleTypeGenerator>()
    .AddTransient<EnumTypeGenerator>()
    .AddTransient<BaseTypeGenerator>()
    .AddTransient<FuncPointerGenerator>()
    .AddTransient<UnionTypeGenerator>()
    .AddTransient<BitMaskTypeGenerator>()
    .AddHostedService<GeneratorService>();

await builder.Build().RunAsync();