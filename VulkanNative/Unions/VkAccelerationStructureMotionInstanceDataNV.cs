using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Explicit)]
public unsafe struct VkAccelerationStructureMotionInstanceDataNV
{
    [FieldOffset(0)]
    public VkAccelerationStructureInstanceKHR StaticInstance;
    [FieldOffset(0)]
    public VkAccelerationStructureMatrixMotionInstanceNV MatrixMotionInstance;
    [FieldOffset(0)]
    public VkAccelerationStructureSRTMotionInstanceNV SrtMotionInstance;
}