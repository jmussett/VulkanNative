using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkAttachmentDescription2
{
    public VkStructureType sType;
    public void* pNext;
    public VkAttachmentDescriptionFlags flags;
    public VkFormat format;
    public VkSampleCountFlags samples;
    public VkAttachmentLoadOp loadOp;
    public VkAttachmentStoreOp storeOp;
    public VkAttachmentLoadOp stencilLoadOp;
    public VkAttachmentStoreOp stencilStoreOp;
    public VkImageLayout initialLayout;
    public VkImageLayout finalLayout;
}