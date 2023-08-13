using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkAccelerationStructureBuildSizesInfoKHR
{
    public VkStructureType SType;
    public void* PNext;
    public VkDeviceSize AccelerationStructureSize;
    public VkDeviceSize UpdateScratchSize;
    public VkDeviceSize BuildScratchSize;
}