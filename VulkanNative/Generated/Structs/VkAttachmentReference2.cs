using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkAttachmentReference2
{
    public VkStructureType sType;
    public void* pNext;
    public uint attachment;
    public VkImageLayout layout;
    public VkImageAspectFlags aspectMask;
}