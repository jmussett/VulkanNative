using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImageFormatProperties
{
    public VkExtent3D maxExtent;
    public uint maxMipLevels;
    public uint maxArrayLayers;
    public VkSampleCountFlags sampleCounts;
    public VkDeviceSize maxResourceSize;
}