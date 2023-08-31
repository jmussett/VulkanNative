using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkGeometryNV
{
    public VkStructureType sType;
    public void* pNext;
    public VkGeometryTypeKHR geometryType;
    public VkGeometryDataNV geometry;
    public VkGeometryFlagsKHR flags;
}