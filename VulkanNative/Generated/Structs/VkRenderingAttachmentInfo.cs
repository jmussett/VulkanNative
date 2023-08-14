using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkRenderingAttachmentInfo
{
    public VkStructureType SType;
    public void* PNext;
    public VkImageView ImageView;
    public VkImageLayout ImageLayout;
    public VkResolveModeFlags ResolveMode;
    public VkImageView ResolveImageView;
    public VkImageLayout ResolveImageLayout;
    public VkAttachmentLoadOp LoadOp;
    public VkAttachmentStoreOp StoreOp;
    public VkClearValue ClearValue;
}