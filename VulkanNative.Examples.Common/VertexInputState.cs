namespace VulkanNative.Examples.Common;

public sealed class VertexInputState
{
    public VkVertexInputBindingDescription[] VertexBindingDescriptions { get; set; } = Array.Empty<VkVertexInputBindingDescription>();
    public VkVertexInputAttributeDescription[] VertexAttributeDescriptions { get; set; } = Array.Empty<VkVertexInputAttributeDescription>();
}
