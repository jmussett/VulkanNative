using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkAccelerationStructureGeometryTrianglesDataKHR
{
    public VkStructureType SType;
    public void* PNext;
    public VkFormat VertexFormat;
    public VkDeviceOrHostAddressConstKHR VertexData;
    public VkDeviceSize VertexStride;
    public uint MaxVertex;
    public VkIndexType IndexType;
    public VkDeviceOrHostAddressConstKHR IndexData;
    public VkDeviceOrHostAddressConstKHR TransformData;
}