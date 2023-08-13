using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceSparseImageFormatInfo2
{
    public VkStructureType SType;
    public void* PNext;
    public VkFormat Format;
    public VkImageType Type;
    public VkSampleCountFlags Samples;
    public VkImageUsageFlags Usage;
    public VkImageTiling Tiling;
}