using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkGeometryAABBNV
{
    public VkStructureType sType;
    public void* pNext;
    public VkBuffer aabbData;
    public uint numAABBs;
    public uint stride;
    public VkDeviceSize offset;

    public VkGeometryAABBNV()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_GEOMETRY_AABB_NV;
    }
}