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
}