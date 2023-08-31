using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceVideoFormatInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkImageUsageFlags imageUsage;
}