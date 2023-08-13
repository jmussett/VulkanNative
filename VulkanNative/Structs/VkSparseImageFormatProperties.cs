using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSparseImageFormatProperties
{
    public VkImageAspectFlags AspectMask;
    public VkExtent3D ImageGranularity;
    public VkSparseImageFormatFlags Flags;
}