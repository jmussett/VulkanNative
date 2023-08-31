using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSparseImageFormatProperties
{
    public VkImageAspectFlags aspectMask;
    public VkExtent3D imageGranularity;
    public VkSparseImageFormatFlags flags;
}