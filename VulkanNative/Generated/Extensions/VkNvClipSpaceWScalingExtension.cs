using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkNvClipSpaceWScalingExtension
{
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, uint, VkViewportWScalingNV*, void> _vkCmdSetViewportWScalingNV;

    public VkNvClipSpaceWScalingExtension(VkDevice device, IVulkanLoader loader)
    {
        _vkCmdSetViewportWScalingNV = (delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, uint, VkViewportWScalingNV*, void>)loader.GetDeviceProcAddr(device, "vkCmdSetViewportWScalingNV");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdSetViewportWScalingNV(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, VkViewportWScalingNV* pViewportWScalings)
    {
        _vkCmdSetViewportWScalingNV(commandBuffer, firstViewport, viewportCount, pViewportWScalings);
    }
}