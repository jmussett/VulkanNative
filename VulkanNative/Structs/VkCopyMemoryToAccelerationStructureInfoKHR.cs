using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCopyMemoryToAccelerationStructureInfoKHR
{
    public VkStructureType SType;
    public void* PNext;
    public VkDeviceOrHostAddressConstKHR Src;
    public VkAccelerationStructureKHR Dst;
    public VkCopyAccelerationStructureModeKHR Mode;
}