using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkAccelerationStructureMotionInstanceNV
{
    public VkAccelerationStructureMotionInstanceTypeNV type;
    public VkAccelerationStructureMotionInstanceFlagsNV flags;
    public VkAccelerationStructureMotionInstanceDataNV data;
}