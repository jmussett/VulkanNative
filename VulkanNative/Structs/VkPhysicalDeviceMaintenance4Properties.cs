using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceMaintenance4Properties
{
    public VkStructureType SType;
    public void* PNext;
    public VkDeviceSize MaxBufferSize;
}