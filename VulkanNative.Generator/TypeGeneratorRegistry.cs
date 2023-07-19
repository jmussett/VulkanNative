using Microsoft.CodeAnalysis.CSharp.Syntax;
using VulkanNative.Generator.Registry;

namespace VulkanNative.Generator
{
    internal class TypeGeneratorRegistry
    {
        private readonly Dictionary<string, ITypeGenerator> _generators = new();

        public void RegisterGenerator(string name, ITypeGenerator generator)
        {
            _generators.Add(name, generator);
        }

        public TypeSyntax GenerateType(VkType type)
        {
            if (!_generators.TryGetValue(type.Category, out var generator))
            {
                throw new InvalidOperationException($"Unable to find generator for type '{type.Category}'");
            }

            return generator.GenerateType(type);
        }
    }
}
