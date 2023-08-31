using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkMicromapBuildInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkMicromapTypeEXT type;
    public VkBuildMicromapFlagsEXT flags;
    public VkBuildMicromapModeEXT mode;
    public VkMicromapEXT dstMicromap;
    public uint usageCountsCount;
    public VkMicromapUsageEXT* pUsageCounts;
    public VkMicromapUsageEXT** ppUsageCounts;
    public VkDeviceOrHostAddressConstKHR data;
    public VkDeviceOrHostAddressKHR scratchData;
    public VkDeviceOrHostAddressConstKHR triangleArray;
    public VkDeviceSize triangleArrayStride;

    public VkMicromapBuildInfoEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_MICROMAP_BUILD_INFO_EXT;
    }
}