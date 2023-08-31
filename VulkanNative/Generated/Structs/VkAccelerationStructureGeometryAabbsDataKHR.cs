using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkAccelerationStructureGeometryAabbsDataKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkDeviceOrHostAddressConstKHR data;
    public VkDeviceSize stride;

    public VkAccelerationStructureGeometryAabbsDataKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_GEOMETRY_AABBS_DATA_KHR;
    }
}