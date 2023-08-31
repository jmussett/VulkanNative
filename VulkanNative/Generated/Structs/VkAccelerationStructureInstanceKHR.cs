using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkAccelerationStructureInstanceKHR
{
    public VkTransformMatrixKHR transform;
    public uint instanceCustomIndex;
    public uint mask;
    public uint instanceShaderBindingTableRecordOffset;
    public VkGeometryInstanceFlagsKHR flags;
    public ulong accelerationStructureReference;
}