using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkAttachmentDescription
{
    public VkAttachmentDescriptionFlags Flags;
    public VkFormat Format;
    public VkSampleCountFlags Samples;
    public VkAttachmentLoadOp LoadOp;
    public VkAttachmentStoreOp StoreOp;
    public VkAttachmentLoadOp StencilLoadOp;
    public VkAttachmentStoreOp StencilStoreOp;
    public VkImageLayout InitialLayout;
    public VkImageLayout FinalLayout;
}