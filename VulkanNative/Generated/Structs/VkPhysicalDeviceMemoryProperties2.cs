using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceMemoryProperties2
{
    public VkStructureType sType;
    public void* pNext;
    public VkPhysicalDeviceMemoryProperties memoryProperties;
}