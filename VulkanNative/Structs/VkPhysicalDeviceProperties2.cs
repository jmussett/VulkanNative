using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceProperties2
{
    public VkStructureType SType;
    public void* PNext;
    public VkPhysicalDeviceProperties Properties;
}