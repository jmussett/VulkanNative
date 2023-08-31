using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDisplayPlaneCapabilities2KHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkDisplayPlaneCapabilitiesKHR capabilities;
}