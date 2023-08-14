using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Explicit)]
public unsafe struct VkAccelerationStructureGeometryDataKHR
{
    [FieldOffset(0)]
    public VkAccelerationStructureGeometryTrianglesDataKHR Triangles;
    [FieldOffset(0)]
    public VkAccelerationStructureGeometryAabbsDataKHR Aabbs;
    [FieldOffset(0)]
    public VkAccelerationStructureGeometryInstancesDataKHR Instances;
}