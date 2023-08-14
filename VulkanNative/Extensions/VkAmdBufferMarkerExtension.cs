using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkAmdBufferMarkerExtension
{
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPipelineStageFlags, VkBuffer, VkDeviceSize, uint, void> _vkCmdWriteBufferMarkerAMD;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdWriteBufferMarkerAMD(VkCommandBuffer commandBuffer, VkPipelineStageFlags pipelineStage, VkBuffer dstBuffer, VkDeviceSize dstOffset, uint marker)
    {
        _vkCmdWriteBufferMarkerAMD(commandBuffer, pipelineStage, dstBuffer, dstOffset, marker);
    }
}