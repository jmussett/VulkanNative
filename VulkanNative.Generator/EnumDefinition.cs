using VulkanNative.Generator.Registry;

namespace VulkanNative.Generator;

internal class EnumDefinition
{
    public string? EnumType { get; set; }
    public string? ClrTypeName { get; set; }
    public string? BitWidth { get; set; }
    public List<VkEnum> Members { get; } = new();
}
