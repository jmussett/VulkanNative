using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineViewportExclusiveScissorStateCreateInfoNV
{
    public VkStructureType SType;
    public void* PNext;
    public uint ExclusiveScissorCount;
    public VkRect2D* PExclusiveScissors;
}