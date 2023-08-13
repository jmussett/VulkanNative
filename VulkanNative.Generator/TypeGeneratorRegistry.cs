using CSharpComposer;
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
