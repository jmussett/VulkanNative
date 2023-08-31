using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkAccelerationStructureMatrixMotionInstanceNV
{
    public VkTransformMatrixKHR transformT0;
    public VkTransformMatrixKHR transformT1;
    public uint instanceCustomIndex;
    public uint mask;
    public uint instanceShaderBindingTableRecordOffset;
    public VkGeometryInstanceFlagsKHR flags;
    public ulong accelerationStructureReference;
}