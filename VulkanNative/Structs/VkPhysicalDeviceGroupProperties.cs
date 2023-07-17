using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceGroupProperties
{
    public VkStructureType sType;
    public void* pNext;
    public uint physicalDeviceCount;
    public VkPhysicalDevice physicalDevices;
    public VkBool32 subsetAllocation;
}