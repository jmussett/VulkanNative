using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCopyAccelerationStructureInfoKHR
{
    public VkStructureType SType;
    public void* PNext;
    public VkAccelerationStructureKHR Src;
    public VkAccelerationStructureKHR Dst;
    public VkCopyAccelerationStructureModeKHR Mode;
}