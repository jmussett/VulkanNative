using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkExtConditionalRenderingExtension
{
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkConditionalRenderingBeginInfoEXT*, void> _vkCmdBeginConditionalRenderingEXT;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, void> _vkCmdEndConditionalRenderingEXT;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdBeginConditionalRenderingEXT(VkCommandBuffer commandBuffer, VkConditionalRenderingBeginInfoEXT* pConditionalRenderingBegin)
    {
        _vkCmdBeginConditionalRenderingEXT(commandBuffer, pConditionalRenderingBegin);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdEndConditionalRenderingEXT(VkCommandBuffer commandBuffer)
    {
        _vkCmdEndConditionalRenderingEXT(commandBuffer);
    }
}