using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkExtConditionalRenderingExtension
{
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkConditionalRenderingBeginInfoEXT*, void> _vkCmdBeginConditionalRenderingEXT;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, void> _vkCmdEndConditionalRenderingEXT;

    public VkExtConditionalRenderingExtension(VkDevice device, IFunctionLoader loader)
    {
        _vkCmdBeginConditionalRenderingEXT = (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkConditionalRenderingBeginInfoEXT*, void>)loader.GetDeviceProcAddr(device, "vkCmdBeginConditionalRenderingEXT");
        _vkCmdEndConditionalRenderingEXT = (delegate* unmanaged[Cdecl]<VkCommandBuffer, void>)loader.GetDeviceProcAddr(device, "vkCmdEndConditionalRenderingEXT");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void vkCmdBeginConditionalRenderingEXT(VkCommandBuffer commandBuffer, VkConditionalRenderingBeginInfoEXT* pConditionalRenderingBegin)
    {
        _vkCmdBeginConditionalRenderingEXT(commandBuffer, pConditionalRenderingBegin);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void vkCmdEndConditionalRenderingEXT(VkCommandBuffer commandBuffer)
    {
        _vkCmdEndConditionalRenderingEXT(commandBuffer);
    }
}