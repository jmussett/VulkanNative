using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkAttachmentDescriptionStencilLayout
{
    public VkStructureType sType;
    public void* pNext;
    public VkImageLayout stencilInitialLayout;
    public VkImageLayout stencilFinalLayout;
}