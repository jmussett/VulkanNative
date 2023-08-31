using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkAccelerationStructureGeometryKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkGeometryTypeKHR geometryType;
    public VkAccelerationStructureGeometryDataKHR geometry;
    public VkGeometryFlagsKHR flags;

    public VkAccelerationStructureGeometryKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_GEOMETRY_KHR;
    }
}