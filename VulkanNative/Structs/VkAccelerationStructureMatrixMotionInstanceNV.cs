using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkAccelerationStructureMatrixMotionInstanceNV
{
    public VkTransformMatrixKHR TransformT0;
    public VkTransformMatrixKHR TransformT1;
    public uint InstanceCustomIndex;
    public uint Mask;
    public uint InstanceShaderBindingTableRecordOffset;
    public VkGeometryInstanceFlagsKHR Flags;
    public ulong AccelerationStructureReference;
}