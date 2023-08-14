using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkGeometryNV
{
    public VkStructureType SType;
    public void* PNext;
    public VkGeometryTypeKHR GeometryType;
    public VkGeometryDataNV Geometry;
    public VkGeometryFlagsKHR Flags;
}