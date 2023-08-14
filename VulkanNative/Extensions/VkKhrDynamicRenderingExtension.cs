using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkKhrDynamicRenderingExtension
{
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkRenderingInfo*, void> _vkCmdBeginRendering;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, void> _vkCmdEndRendering;

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