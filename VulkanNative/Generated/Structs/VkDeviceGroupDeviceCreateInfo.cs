using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDeviceGroupDeviceCreateInfo
{
    public VkStructureType SType;
    public void* PNext;
    public uint PhysicalDeviceCount;
    public VkPhysicalDevice* PPhysicalDevices;
}