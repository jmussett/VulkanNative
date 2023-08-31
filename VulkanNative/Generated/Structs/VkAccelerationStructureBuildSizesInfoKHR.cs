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
}