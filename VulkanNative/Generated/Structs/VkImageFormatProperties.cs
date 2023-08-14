using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImageFormatProperties
{
    public VkExtent3D MaxExtent;
    public uint MaxMipLevels;
    public uint MaxArrayLayers;
    public VkSampleCountFlags SampleCounts;
    public VkDeviceSize MaxResourceSize;
}