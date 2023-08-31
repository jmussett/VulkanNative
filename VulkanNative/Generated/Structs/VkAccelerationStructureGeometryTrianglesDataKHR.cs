using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkAccelerationStructureGeometryTrianglesDataKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkFormat vertexFormat;
    public VkDeviceOrHostAddressConstKHR vertexData;
    public VkDeviceSize vertexStride;
    public uint maxVertex;
    public VkIndexType indexType;
    public VkDeviceOrHostAddressConstKHR indexData;
    public VkDeviceOrHostAddressConstKHR transformData;
}