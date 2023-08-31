using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkAccelerationStructureGeometryAabbsDataKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkDeviceOrHostAddressConstKHR data;
    public VkDeviceSize stride;
}