using CSharpComposer;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace VulkanNative.Generator.Registries;

internal class TypeRegistry
{
    public Dictionary<string, TypeSyntax> Types { get; } = new()
    {
        // Initial primitive types

        // the bitwidth of chars in C# (16 bits) do not match the bitwidth of chars in C (8 bits)
        // so we use bytes instead (8 bits)
        { "char", CSharpFactory.Type("byte") },

        { "void", CSharpFactory.Type("void") },
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
        { "size_t", CSharpFactory.Type("nuint") }
    };
}
