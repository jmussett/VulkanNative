using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Explicit)]
public unsafe struct VkAccelerationStructureGeometryDataKHR
{
    [FieldOffset(0)]
    public VkAccelerationStructureGeometryTrianglesDataKHR triangles;
    [FieldOffset(0)]
    public VkAccelerationStructureGeometryAabbsDataKHR aabbs;
    [FieldOffset(0)]
    public VkAccelerationStructureGeometryInstancesDataKHR instances;
}