using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkAccelerationStructureMotionInfoNV
{
    public VkStructureType SType;
    public void* PNext;
    public uint MaxInstances;
    public VkAccelerationStructureMotionInfoFlagsNV Flags;
}