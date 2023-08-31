using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkAccelerationStructureGeometryInstancesDataKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 arrayOfPointers;
    public VkDeviceOrHostAddressConstKHR data;

    public VkAccelerationStructureGeometryInstancesDataKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_GEOMETRY_INSTANCES_DATA_KHR;
    }
}