namespace VulkanNative.Examples.Common;

public struct CommandSubmission
{
    public ArraySegment<CommandBuffer> CommandBuffers { get; set; }
    public ArraySegment<VulkanSemaphore> WaitSemaphores { get; set; }
    public ArraySegment<VulkanSemaphore> SignalSemaphores { get; set; }
    public ArraySegment<VkPipelineStageFlags> WaitStages { get; set; }
}