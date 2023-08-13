using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkAccelerationStructureSRTMotionInstanceNV
{
    public VkSRTDataNV TransformT0;
    public VkSRTDataNV TransformT1;
    public uint InstanceCustomIndex;
    public uint Mask;
    public uint InstanceShaderBindingTableRecordOffset;
    public VkGeometryInstanceFlagsKHR Flags;
    public ulong AccelerationStructureReference;
}