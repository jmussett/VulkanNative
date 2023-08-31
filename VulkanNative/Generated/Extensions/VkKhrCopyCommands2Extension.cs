using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkKhrCopyCommands2Extension
{
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCopyBufferInfo2*, void> _vkCmdCopyBuffer2;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCopyImageInfo2*, void> _vkCmdCopyImage2;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCopyBufferToImageInfo2*, void> _vkCmdCopyBufferToImage2;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCopyImageToBufferInfo2*, void> _vkCmdCopyImageToBuffer2;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBlitImageInfo2*, void> _vkCmdBlitImage2;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkResolveImageInfo2*, void> _vkCmdResolveImage2;

    public VkKhrCopyCommands2Extension(VkDevice device, IFunctionLoader loader)
    {
        _vkCmdCopyBuffer2 = (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCopyBufferInfo2*, void>)loader.GetDeviceProcAddr(device, "vkCmdCopyBuffer2");
        _vkCmdCopyImage2 = (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCopyImageInfo2*, void>)loader.GetDeviceProcAddr(device, "vkCmdCopyImage2");
        _vkCmdCopyBufferToImage2 = (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCopyBufferToImageInfo2*, void>)loader.GetDeviceProcAddr(device, "vkCmdCopyBufferToImage2");
        _vkCmdCopyImageToBuffer2 = (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCopyImageToBufferInfo2*, void>)loader.GetDeviceProcAddr(device, "vkCmdCopyImageToBuffer2");
        _vkCmdBlitImage2 = (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBlitImageInfo2*, void>)loader.GetDeviceProcAddr(device, "vkCmdBlitImage2");
        _vkCmdResolveImage2 = (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkResolveImageInfo2*, void>)loader.GetDeviceProcAddr(device, "vkCmdResolveImage2");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void vkCmdCopyBuffer2(VkCommandBuffer commandBuffer, VkCopyBufferInfo2* pCopyBufferInfo)
    {
        _vkCmdCopyBuffer2(commandBuffer, pCopyBufferInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void vkCmdCopyImage2(VkCommandBuffer commandBuffer, VkCopyImageInfo2* pCopyImageInfo)
    {
        _vkCmdCopyImage2(commandBuffer, pCopyImageInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void vkCmdCopyBufferToImage2(VkCommandBuffer commandBuffer, VkCopyBufferToImageInfo2* pCopyBufferToImageInfo)
    {
        _vkCmdCopyBufferToImage2(commandBuffer, pCopyBufferToImageInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void vkCmdCopyImageToBuffer2(VkCommandBuffer commandBuffer, VkCopyImageToBufferInfo2* pCopyImageToBufferInfo)
    {
        _vkCmdCopyImageToBuffer2(commandBuffer, pCopyImageToBufferInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void vkCmdBlitImage2(VkCommandBuffer commandBuffer, VkBlitImageInfo2* pBlitImageInfo)
    {
        _vkCmdBlitImage2(commandBuffer, pBlitImageInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void vkCmdResolveImage2(VkCommandBuffer commandBuffer, VkResolveImageInfo2* pResolveImageInfo)
    {
        _vkCmdResolveImage2(commandBuffer, pResolveImageInfo);
    }
}