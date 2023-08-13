using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceMaintenance3Properties
{
    public VkStructureType sType;
    public void* pNext;
    public uint maxPerSetDescriptors;
    public VkDeviceSize maxMemoryAllocationSize;
}