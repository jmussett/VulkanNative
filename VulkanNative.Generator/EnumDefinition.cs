using VulkanNative.Generator.Registry;

namespace VulkanNative.Generator;

internal class EnumDefinition
{
    public string? EnumType { get; set; }
    public string? ClrTypeName { get; set; }
    public string? BitWidth { get; set; }
    public int? ExtensionNumber { get; set; }
    public Dictionary<string, VkEnum> Members { get; } = new();
}
