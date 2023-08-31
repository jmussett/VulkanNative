using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkAccelerationStructureGeometryMotionTrianglesDataNV
{
    public VkStructureType sType;
    public void* pNext;
    public VkDeviceOrHostAddressConstKHR vertexData;

    public VkAccelerationStructureGeometryMotionTrianglesDataNV()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_GEOMETRY_MOTION_TRIANGLES_DATA_NV;
    }
}