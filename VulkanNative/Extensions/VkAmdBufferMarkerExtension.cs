namespace VulkanNative;

public unsafe class VkAmdBufferMarkerExtension
{
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPipelineStageFlags, VkBuffer, VkDeviceSize, uint, void> vkCmdWriteBufferMarkerAMD;
}