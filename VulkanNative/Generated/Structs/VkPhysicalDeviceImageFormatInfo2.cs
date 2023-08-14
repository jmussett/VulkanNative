using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceImageFormatInfo2
{
    public VkStructureType SType;
    public void* PNext;
    public VkFormat Format;
    public VkImageType Type;
    public VkImageTiling Tiling;
    public VkImageUsageFlags Usage;
    public VkImageCreateFlags Flags;
}