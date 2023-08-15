using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkNvCopyMemoryIndirectExtension
{
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDeviceAddress, uint, uint, void> _vkCmdCopyMemoryIndirectNV;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDeviceAddress, uint, uint, VkImage, VkImageLayout, VkImageSubresourceLayers*, void> _vkCmdCopyMemoryToImageIndirectNV;

    public VkNvCopyMemoryIndirectExtension(VkDevice device, IVulkanLoader loader)
    {
        _vkCmdCopyMemoryIndirectNV = (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDeviceAddress, uint, uint, void>)loader.GetDeviceProcAddr(device, "vkCmdCopyMemoryIndirectNV");
        _vkCmdCopyMemoryToImageIndirectNV = (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDeviceAddress, uint, uint, VkImage, VkImageLayout, VkImageSubresourceLayers*, void>)loader.GetDeviceProcAddr(device, "vkCmdCopyMemoryToImageIndirectNV");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdCopyMemoryIndirectNV(VkCommandBuffer commandBuffer, VkDeviceAddress copyBufferAddress, uint copyCount, uint stride)
    {
        _vkCmdCopyMemoryIndirectNV(commandBuffer, copyBufferAddress, copyCount, stride);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdCopyMemoryToImageIndirectNV(VkCommandBuffer commandBuffer, VkDeviceAddress copyBufferAddress, uint copyCount, uint stride, VkImage dstImage, VkImageLayout dstImageLayout, VkImageSubresourceLayers* pImageSubresources)
    {
        _vkCmdCopyMemoryToImageIndirectNV(commandBuffer, copyBufferAddress, copyCount, stride, dstImage, dstImageLayout, pImageSubresources);
    }
}