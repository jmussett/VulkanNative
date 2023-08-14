using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceImageViewImageFormatInfoEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkImageViewType ImageViewType;
}