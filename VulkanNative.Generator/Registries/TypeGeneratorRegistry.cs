using CSharpComposer;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Extensions.DependencyInjection;
using VulkanNative.Generator.Registry;

namespace VulkanNative.Generator.Registries
{
    internal class TypeGeneratorRegistry
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly Dictionary<string, ITypeGenerator> _generators = new();

        public TypeGeneratorRegistry(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void RegisterGenerator<T>(string name) where T : ITypeGenerator
        {
            var generator = _serviceProvider.GetRequiredService<T>();

            _generators.Add(name, generator);
        }

        public TypeSyntax GenerateType(string name, VkType type)
        {
            if (type.Category is null || !_generators.TryGetValue(type.Category, out var generator))
            {
                // For external dependencies (like xlib) we don't know the type, so we just return a native int.
                return CSharpFactory.Type("nint");
            }

            return generator.GenerateType(name, type);
        }
    }
}
