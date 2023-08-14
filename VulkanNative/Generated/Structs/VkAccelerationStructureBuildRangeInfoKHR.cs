using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkAccelerationStructureBuildRangeInfoKHR
{
    public uint PrimitiveCount;
    public uint PrimitiveOffset;
    public uint FirstVertex;
    public uint TransformOffset;
}