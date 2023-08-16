using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkKhrCreateRenderpass2Extension
{
    private delegate* unmanaged[Cdecl]<VkDevice, VkRenderPassCreateInfo2*, VkAllocationCallbacks*, VkRenderPass*, VkResult> _vkCreateRenderPass2;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkRenderPassBeginInfo*, VkSubpassBeginInfo*, void> _vkCmdBeginRenderPass2;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkSubpassBeginInfo*, VkSubpassEndInfo*, void> _vkCmdNextSubpass2;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkSubpassEndInfo*, void> _vkCmdEndRenderPass2;

    public VkKhrCreateRenderpass2Extension(VkDevice device, IFunctionLoader loader)
    {
        _vkCreateRenderPass2 = (delegate* unmanaged[Cdecl]<VkDevice, VkRenderPassCreateInfo2*, VkAllocationCallbacks*, VkRenderPass*, VkResult>)loader.GetDeviceProcAddr(device, "vkCreateRenderPass2");
        _vkCmdBeginRenderPass2 = (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkRenderPassBeginInfo*, VkSubpassBeginInfo*, void>)loader.GetDeviceProcAddr(device, "vkCmdBeginRenderPass2");
        _vkCmdNextSubpass2 = (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkSubpassBeginInfo*, VkSubpassEndInfo*, void>)loader.GetDeviceProcAddr(device, "vkCmdNextSubpass2");
        _vkCmdEndRenderPass2 = (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkSubpassEndInfo*, void>)loader.GetDeviceProcAddr(device, "vkCmdEndRenderPass2");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkCreateRenderPass2(VkDevice device, VkRenderPassCreateInfo2* pCreateInfo, VkAllocationCallbacks* pAllocator, VkRenderPass* pRenderPass)
    {
        return _vkCreateRenderPass2(device, pCreateInfo, pAllocator, pRenderPass);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdBeginRenderPass2(VkCommandBuffer commandBuffer, VkRenderPassBeginInfo* pRenderPassBegin, VkSubpassBeginInfo* pSubpassBeginInfo)
    {
        _vkCmdBeginRenderPass2(commandBuffer, pRenderPassBegin, pSubpassBeginInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdNextSubpass2(VkCommandBuffer commandBuffer, VkSubpassBeginInfo* pSubpassBeginInfo, VkSubpassEndInfo* pSubpassEndInfo)
    {
        _vkCmdNextSubpass2(commandBuffer, pSubpassBeginInfo, pSubpassEndInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdEndRenderPass2(VkCommandBuffer commandBuffer, VkSubpassEndInfo* pSubpassEndInfo)
    {
        _vkCmdEndRenderPass2(commandBuffer, pSubpassEndInfo);
    }
}