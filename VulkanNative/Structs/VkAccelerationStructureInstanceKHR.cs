using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkAccelerationStructureInstanceKHR
{
    public VkTransformMatrixKHR Transform;
    public uint InstanceCustomIndex;
    public uint Mask;
    public uint InstanceShaderBindingTableRecordOffset;
    public VkGeometryInstanceFlagsKHR Flags;
    public ulong AccelerationStructureReference;
}