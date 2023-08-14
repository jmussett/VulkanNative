using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceGroupProperties
{
    public VkStructureType SType;
    public void* PNext;
    public uint PhysicalDeviceCount;
    public VkPhysicalDevice* PhysicalDevices;
    public VkBool32 SubsetAllocation;
}