using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDisplayPlaneProperties2KHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkDisplayPlanePropertiesKHR displayPlaneProperties;
}