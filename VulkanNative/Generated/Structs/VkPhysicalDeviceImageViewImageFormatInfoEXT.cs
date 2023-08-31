using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceImageViewImageFormatInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkImageViewType imageViewType;
}