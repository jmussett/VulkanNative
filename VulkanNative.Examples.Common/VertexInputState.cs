using VulkanNative.Examples.Common.Utility;

namespace VulkanNative.Examples.Common;

public sealed class VertexInputState : IDisposable
{
    public VulkanBuffer<VkVertexInputBindingDescription> VertexBindingDescriptions { get; set; } = new();
    public VulkanBuffer<VkVertexInputAttributeDescription> VertexAttributeDescriptions { get; set; } = new();

    public void Dispose()
    {
        VertexBindingDescriptions.Dispose();
        VertexAttributeDescriptions.Dispose();
    }
}
