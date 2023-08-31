using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkAccelerationStructureSRTMotionInstanceNV
{
    public VkSRTDataNV transformT0;
    public VkSRTDataNV transformT1;
    public uint instanceCustomIndex;
    public uint mask;
    public uint instanceShaderBindingTableRecordOffset;
    public VkGeometryInstanceFlagsKHR flags;
    public ulong accelerationStructureReference;
}