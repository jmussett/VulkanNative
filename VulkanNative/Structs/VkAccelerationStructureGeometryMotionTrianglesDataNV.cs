using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkAccelerationStructureGeometryMotionTrianglesDataNV
{
    public VkStructureType SType;
    public void* PNext;
    public VkDeviceOrHostAddressConstKHR VertexData;
}