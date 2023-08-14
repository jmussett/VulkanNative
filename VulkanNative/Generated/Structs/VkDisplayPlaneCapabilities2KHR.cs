using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDisplayPlaneCapabilities2KHR
{
    public VkStructureType SType;
    public void* PNext;
    public VkDisplayPlaneCapabilitiesKHR Capabilities;
}