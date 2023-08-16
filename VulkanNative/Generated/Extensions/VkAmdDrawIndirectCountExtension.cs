using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkAmdDrawIndirectCountExtension
{
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBuffer, VkDeviceSize, VkBuffer, VkDeviceSize, uint, uint, void> _vkCmdDrawIndirectCount;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBuffer, VkDeviceSize, VkBuffer, VkDeviceSize, uint, uint, void> _vkCmdDrawIndexedIndirectCount;

    public VkAmdDrawIndirectCountExtension(VkDevice device, IFunctionLoader loader)
    {
        _vkCmdDrawIndirectCount = (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBuffer, VkDeviceSize, VkBuffer, VkDeviceSize, uint, uint, void>)loader.GetDeviceProcAddr(device, "vkCmdDrawIndirectCount");
        _vkCmdDrawIndexedIndirectCount = (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBuffer, VkDeviceSize, VkBuffer, VkDeviceSize, uint, uint, void>)loader.GetDeviceProcAddr(device, "vkCmdDrawIndexedIndirectCount");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdDrawIndirectCount(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, VkBuffer countBuffer, VkDeviceSize countBufferOffset, uint maxDrawCount, uint stride)
    {
        _vkCmdDrawIndirectCount(commandBuffer, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdDrawIndexedIndirectCount(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, VkBuffer countBuffer, VkDeviceSize countBufferOffset, uint maxDrawCount, uint stride)
    {
        _vkCmdDrawIndexedIndirectCount(commandBuffer, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);
    }
}