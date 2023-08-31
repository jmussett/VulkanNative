using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImageViewCaptureDescriptorDataInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkImageView imageView;

    public VkImageViewCaptureDescriptorDataInfoEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_IMAGE_VIEW_CAPTURE_DESCRIPTOR_DATA_INFO_EXT;
    }
}