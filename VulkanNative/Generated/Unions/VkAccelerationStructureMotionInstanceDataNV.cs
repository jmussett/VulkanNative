using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Explicit)]
public unsafe struct VkAccelerationStructureMotionInstanceDataNV
{
    [FieldOffset(0)]
    public VkAccelerationStructureInstanceKHR staticInstance;
    [FieldOffset(0)]
    public VkAccelerationStructureMatrixMotionInstanceNV matrixMotionInstance;
    [FieldOffset(0)]
    public VkAccelerationStructureSRTMotionInstanceNV srtMotionInstance;
}