using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkGeometryDataNV
{
    public VkGeometryTrianglesNV Triangles;
    public VkGeometryAABBNV Aabbs;
}