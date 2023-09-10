using VulkanNative.Examples.Common.Utility;

namespace VulkanNative.Examples.Common;

public sealed class ViewportState : IDisposable
{
    public VulkanBuffer<VkViewport> Viewports { get; set; } = new();
    public VulkanBuffer<VkRect2D> Scissors { get; set; } = new();

    public void Dispose()
    {
        Viewports.Dispose();
        Scissors.Dispose();

        GC.SuppressFinalize(this);
    }

    ~ViewportState()
    {
        Dispose();
    }
}
