using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkGeometryTrianglesNV
{
    public VkStructureType SType;
    public void* PNext;
    public VkBuffer VertexData;
    public VkDeviceSize VertexOffset;
    public uint VertexCount;
    public VkDeviceSize VertexStride;
    public VkFormat VertexFormat;
    public VkBuffer IndexData;
    public VkDeviceSize IndexOffset;
    public uint IndexCount;
    public VkIndexType IndexType;
    public VkBuffer TransformData;
    public VkDeviceSize TransformOffset;
}