using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkAttachmentDescriptionStencilLayout
{
    public VkStructureType SType;
    public void* PNext;
    public VkImageLayout StencilInitialLayout;
    public VkImageLayout StencilFinalLayout;
}