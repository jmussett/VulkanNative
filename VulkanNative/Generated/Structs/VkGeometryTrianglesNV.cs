using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkGeometryTrianglesNV
{
    public VkStructureType sType;
    public void* pNext;
    public VkBuffer vertexData;
    public VkDeviceSize vertexOffset;
    public uint vertexCount;
    public VkDeviceSize vertexStride;
    public VkFormat vertexFormat;
    public VkBuffer indexData;
    public VkDeviceSize indexOffset;
    public uint indexCount;
    public VkIndexType indexType;
    public VkBuffer transformData;
    public VkDeviceSize transformOffset;

    public VkGeometryTrianglesNV()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_GEOMETRY_TRIANGLES_NV;
    }
}