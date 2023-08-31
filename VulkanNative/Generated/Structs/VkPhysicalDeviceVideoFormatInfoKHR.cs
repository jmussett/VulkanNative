using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceVideoFormatInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkImageUsageFlags imageUsage;

    public VkPhysicalDeviceVideoFormatInfoKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VIDEO_FORMAT_INFO_KHR;
    }
}