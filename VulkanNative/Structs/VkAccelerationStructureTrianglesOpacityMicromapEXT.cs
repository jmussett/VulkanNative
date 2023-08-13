using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkAccelerationStructureTrianglesOpacityMicromapEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkIndexType IndexType;
    public VkDeviceOrHostAddressConstKHR IndexBuffer;
    public VkDeviceSize IndexStride;
    public uint BaseTriangle;
    public uint UsageCountsCount;
    public VkMicromapUsageEXT* PUsageCounts;
    public VkMicromapUsageEXT** PpUsageCounts;
    public VkMicromapEXT Micromap;
}