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

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdCopyBuffer2(VkCommandBuffer commandBuffer, VkCopyBufferInfo2* pCopyBufferInfo)
    {
        _vkCmdCopyBuffer2(commandBuffer, pCopyBufferInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdCopyImage2(VkCommandBuffer commandBuffer, VkCopyImageInfo2* pCopyImageInfo)
    {
        _vkCmdCopyImage2(commandBuffer, pCopyImageInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdCopyBufferToImage2(VkCommandBuffer commandBuffer, VkCopyBufferToImageInfo2* pCopyBufferToImageInfo)
    {
        _vkCmdCopyBufferToImage2(commandBuffer, pCopyBufferToImageInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdCopyImageToBuffer2(VkCommandBuffer commandBuffer, VkCopyImageToBufferInfo2* pCopyImageToBufferInfo)
    {
        _vkCmdCopyImageToBuffer2(commandBuffer, pCopyImageToBufferInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdBlitImage2(VkCommandBuffer commandBuffer, VkBlitImageInfo2* pBlitImageInfo)
    {
        _vkCmdBlitImage2(commandBuffer, pBlitImageInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdResolveImage2(VkCommandBuffer commandBuffer, VkResolveImageInfo2* pResolveImageInfo)
    {
        _vkCmdResolveImage2(commandBuffer, pResolveImageInfo);
    }
}