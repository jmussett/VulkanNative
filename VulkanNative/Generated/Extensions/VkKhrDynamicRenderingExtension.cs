using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkKhrDynamicRenderingExtension
{
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkRenderingInfo*, void> _vkCmdBeginRendering;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, void> _vkCmdEndRendering;

    public VkKhrDynamicRenderingExtension(VkDevice device, IVulkanLoader loader)
    {
        _vkCmdBeginRendering = (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkRenderingInfo*, void>)loader.GetDeviceProcAddr(device, "vkCmdBeginRendering");
        _vkCmdEndRendering = (delegate* unmanaged[Cdecl]<VkCommandBuffer, void>)loader.GetDeviceProcAddr(device, "vkCmdEndRendering");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdBeginRendering(VkCommandBuffer commandBuffer, VkRenderingInfo* pRenderingInfo)
    {
        _vkCmdBeginRendering(commandBuffer, pRenderingInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdEndRendering(VkCommandBuffer commandBuffer)
    {
        _vkCmdEndRendering(commandBuffer);
    }
}