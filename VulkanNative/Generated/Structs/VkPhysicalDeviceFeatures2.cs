using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceFeatures2
{
    public VkStructureType sType;
    public void* pNext;
    public VkPhysicalDeviceFeatures features;
}