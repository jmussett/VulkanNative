using VulkanNative.Examples.Common.Utility;

namespace VulkanNative.Examples.Common;

public sealed class ViewportState
{
    public VkViewport[] Viewports { get; set; }
    public VkRect2D[] Scissors { get; set; }
}
