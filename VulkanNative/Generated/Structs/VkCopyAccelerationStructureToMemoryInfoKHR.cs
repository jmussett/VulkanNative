using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCopyAccelerationStructureToMemoryInfoKHR
{
    public VkStructureType SType;
    public void* PNext;
    public VkAccelerationStructureKHR Src;
    public VkDeviceOrHostAddressKHR Dst;
    public VkCopyAccelerationStructureModeKHR Mode;
}