using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkAccelerationStructureGeometryKHR
{
    public VkStructureType SType;
    public void* PNext;
    public VkGeometryTypeKHR GeometryType;
    public VkAccelerationStructureGeometryDataKHR Geometry;
    public VkGeometryFlagsKHR Flags;
}