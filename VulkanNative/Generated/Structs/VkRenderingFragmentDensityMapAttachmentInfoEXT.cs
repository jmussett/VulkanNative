using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkRenderingFragmentDensityMapAttachmentInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkImageView imageView;
    public VkImageLayout imageLayout;
}