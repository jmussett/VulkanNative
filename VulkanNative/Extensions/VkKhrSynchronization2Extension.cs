namespace VulkanNative;

public unsafe class VkKhrSynchronization2Extension
{
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkEvent, VkDependencyInfo*, void> vkCmdSetEvent2;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkEvent, VkPipelineStageFlags2, void> vkCmdResetEvent2;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, VkEvent*, VkDependencyInfo*, void> vkCmdWaitEvents2;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDependencyInfo*, void> vkCmdPipelineBarrier2;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPipelineStageFlags2, VkQueryPool, uint, void> vkCmdWriteTimestamp2;
    public delegate* unmanaged[Cdecl]<VkQueue, uint, VkSubmitInfo2*, VkFence, VkResult> vkQueueSubmit2;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPipelineStageFlags2, VkBuffer, VkDeviceSize, uint, void> vkCmdWriteBufferMarker2AMD;
    public delegate* unmanaged[Cdecl]<VkQueue, uint*, VkCheckpointData2NV*, void> vkGetQueueCheckpointData2NV;
}