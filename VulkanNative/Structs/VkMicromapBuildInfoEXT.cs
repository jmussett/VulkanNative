using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkMicromapBuildInfoEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkMicromapTypeEXT Type;
    public VkBuildMicromapFlagsEXT Flags;
    public VkBuildMicromapModeEXT Mode;
    public VkMicromapEXT DstMicromap;
    public uint UsageCountsCount;
    public VkMicromapUsageEXT* PUsageCounts;
    public VkMicromapUsageEXT** PpUsageCounts;
    public VkDeviceOrHostAddressConstKHR Data;
    public VkDeviceOrHostAddressKHR ScratchData;
    public VkDeviceOrHostAddressConstKHR TriangleArray;
    public VkDeviceSize TriangleArrayStride;
}