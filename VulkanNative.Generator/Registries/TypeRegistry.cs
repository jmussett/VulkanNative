using CSharpComposer;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace VulkanNative.Generator.Registries;

internal class TypeRegistry
{
    public Dictionary<string, TypeSyntax> Types { get; } = new()
    {
        // Initial primitive types
        { "void", CSharpFactory.Type("void") },
        { "char", CSharpFactory.Type("char") },
        { "float", CSharpFactory.Type("float") },
        { "double", CSharpFactory.Type("double") },
        { "int8_t", CSharpFactory.Type("sbyte") },
        { "uint8_t", CSharpFactory.Type("byte") },
        { "int16_t", CSharpFactory.Type("short") },
        { "uint16_t", CSharpFactory.Type("ushort") },
        { "int32_t", CSharpFactory.Type("int") },
        { "uint32_t", CSharpFactory.Type("uint") },
        { "int64_t", CSharpFactory.Type("long") },
        { "uint64_t", CSharpFactory.Type("ulong") },
        { "size_t", CSharpFactory.Type("nint") }
    };
}
