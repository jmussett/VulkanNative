using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceImageFormatInfo2
{
    public VkStructureType sType;
    public void* pNext;
    public VkFormat format;
    public VkImageType type;
    public VkImageTiling tiling;
    public VkImageUsageFlags usage;
    public VkImageCreateFlags flags;
}