using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkAttachmentReferenceStencilLayout
{
    public VkStructureType SType;
    public void* PNext;
    public VkImageLayout StencilLayout;
}