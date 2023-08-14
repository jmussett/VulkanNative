using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDisplayPlaneProperties2KHR
{
    public VkStructureType SType;
    public void* PNext;
    public VkDisplayPlanePropertiesKHR DisplayPlaneProperties;
}