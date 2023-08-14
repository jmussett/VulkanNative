using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkAccelerationStructureGeometryAabbsDataKHR
{
    public VkStructureType SType;
    public void* PNext;
    public VkDeviceOrHostAddressConstKHR Data;
    public VkDeviceSize Stride;
}