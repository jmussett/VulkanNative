namespace VulkanNative.Generator.Registries;

internal class TypeRegistry
{
    public Dictionary<string, string> Types { get; } = new()
    {
        // Initial primitive types
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
}
