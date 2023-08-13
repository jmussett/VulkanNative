using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceVideoFormatInfoKHR
{
    public VkStructureType SType;
    public void* PNext;
    public VkImageUsageFlags ImageUsage;
}