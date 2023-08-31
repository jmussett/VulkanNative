using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDevicePerformanceQueryPropertiesKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 allowCommandBufferQueryCopies;
}