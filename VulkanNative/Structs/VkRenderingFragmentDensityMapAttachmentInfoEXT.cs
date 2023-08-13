using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkRenderingFragmentDensityMapAttachmentInfoEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkImageView ImageView;
    public VkImageLayout ImageLayout;
}