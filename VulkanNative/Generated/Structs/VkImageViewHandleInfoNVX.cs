using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImageViewHandleInfoNVX
{
    public VkStructureType sType;
    public void* pNext;
    public VkImageView imageView;
    public VkDescriptorType descriptorType;
    public VkSampler sampler;

    public VkImageViewHandleInfoNVX()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_IMAGE_VIEW_HANDLE_INFO_NVX;
    }
}