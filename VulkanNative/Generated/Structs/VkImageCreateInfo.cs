using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImageCreateInfo
{
    public VkStructureType SType;
    public void* PNext;
    public VkImageCreateFlags Flags;
    public VkImageType ImageType;
    public VkFormat Format;
    public VkExtent3D Extent;
    public uint MipLevels;
    public uint ArrayLayers;
    public VkSampleCountFlags Samples;
    public VkImageTiling Tiling;
    public VkImageUsageFlags Usage;
    public VkSharingMode SharingMode;
    public uint QueueFamilyIndexCount;
    public uint* PQueueFamilyIndices;
    public VkImageLayout InitialLayout;
}