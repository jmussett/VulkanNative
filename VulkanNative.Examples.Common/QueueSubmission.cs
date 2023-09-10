using VulkanNative.Examples.Common.Utility;

namespace VulkanNative.Examples.Common;

public class QueueSubmission
{
    public CommandBuffer[] CommandBuffers { get; set; } = Array.Empty<CommandBuffer>();
    public VulkanSemaphore[] WaitSemaphores { get; set; } = Array.Empty<VulkanSemaphore>();
    public VulkanSemaphore[] SignalSemaphores { get; set; } = Array.Empty<VulkanSemaphore>();
    public VulkanBuffer<VkPipelineStageFlags> WaitStages { get; set; } = new();
}