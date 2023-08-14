using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceMaintenance3Properties
{
    public VkStructureType SType;
    public void* PNext;
    public uint MaxPerSetDescriptors;
    public VkDeviceSize MaxMemoryAllocationSize;
}