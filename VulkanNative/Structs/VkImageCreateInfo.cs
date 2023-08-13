using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImageCreateInfo
{
    public VkStructureType sType;
    public void* pNext;
    public VkImageCreateFlags flags;
    public VkImageType imageType;
    public VkFormat format;
    public VkExtent3D extent;
    public uint mipLevels;
    public uint arrayLayers;
    public VkSampleCountFlags samples;
    public VkImageTiling tiling;
    public VkImageUsageFlags usage;
    public VkSharingMode sharingMode;
    public uint queueFamilyIndexCount;
    public uint* pQueueFamilyIndices;
    public VkImageLayout initialLayout;
}