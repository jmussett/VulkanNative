using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoFormatPropertiesKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkFormat format;
    public VkComponentMapping componentMapping;
    public VkImageCreateFlags imageCreateFlags;
    public VkImageType imageType;
    public VkImageTiling imageTiling;
    public VkImageUsageFlags imageUsageFlags;
}