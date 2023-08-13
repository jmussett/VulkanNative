using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoFormatPropertiesKHR
{
    public VkStructureType SType;
    public void* PNext;
    public VkFormat Format;
    public VkComponentMapping ComponentMapping;
    public VkImageCreateFlags ImageCreateFlags;
    public VkImageType ImageType;
    public VkImageTiling ImageTiling;
    public VkImageUsageFlags ImageUsageFlags;
}