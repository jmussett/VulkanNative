using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkAmdBufferMarkerExtension
{
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPipelineStageFlags, VkBuffer, VkDeviceSize, uint, void> _vkCmdWriteBufferMarkerAMD;

    public VkAmdBufferMarkerExtension(VkDevice device, IVulkanLoader loader)
    {
        _vkCmdWriteBufferMarkerAMD = (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPipelineStageFlags, VkBuffer, VkDeviceSize, uint, void>)loader.GetDeviceProcAddr(device, "vkCmdWriteBufferMarkerAMD");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdWriteBufferMarkerAMD(VkCommandBuffer commandBuffer, VkPipelineStageFlags pipelineStage, VkBuffer dstBuffer, VkDeviceSize dstOffset, uint marker)
    {
        _vkCmdWriteBufferMarkerAMD(commandBuffer, pipelineStage, dstBuffer, dstOffset, marker);
    }
}