using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkRenderingFragmentDensityMapAttachmentInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkImageView imageView;
    public VkImageLayout imageLayout;

    public VkRenderingFragmentDensityMapAttachmentInfoEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_RENDERING_FRAGMENT_DENSITY_MAP_ATTACHMENT_INFO_EXT;
    }
}