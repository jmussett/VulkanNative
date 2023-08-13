using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkAttachmentReferenceStencilLayout
{
    public VkStructureType sType;
    public void* pNext;
    public VkImageLayout stencilLayout;
}