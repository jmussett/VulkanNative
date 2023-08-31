using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkAccelerationStructureBuildRangeInfoKHR
{
    public uint primitiveCount;
    public uint primitiveOffset;
    public uint firstVertex;
    public uint transformOffset;
}