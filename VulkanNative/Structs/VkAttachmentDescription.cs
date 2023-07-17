using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkAttachmentDescription
{
    public VkAttachmentDescriptionFlags flags;
    public VkFormat format;
    public VkSampleCountFlagBits samples;
    public VkAttachmentLoadOp loadOp;
    public VkAttachmentStoreOp storeOp;
    public VkAttachmentLoadOp stencilLoadOp;
    public VkAttachmentStoreOp stencilStoreOp;
    public VkImageLayout initialLayout;
    public VkImageLayout finalLayout;
}