using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkAccelerationStructureBuildSizesInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkDeviceSize accelerationStructureSize;
    public VkDeviceSize updateScratchSize;
    public VkDeviceSize buildScratchSize;

    public VkAccelerationStructureBuildSizesInfoKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_BUILD_SIZES_INFO_KHR;
    }
}