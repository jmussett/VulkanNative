namespace VulkanNative;

public unsafe class VkKhrCopyCommands2Extension
{
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCopyBufferInfo2*, void> vkCmdCopyBuffer2;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCopyImageInfo2*, void> vkCmdCopyImage2;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCopyBufferToImageInfo2*, void> vkCmdCopyBufferToImage2;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCopyImageToBufferInfo2*, void> vkCmdCopyImageToBuffer2;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBlitImageInfo2*, void> vkCmdBlitImage2;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkResolveImageInfo2*, void> vkCmdResolveImage2;
}