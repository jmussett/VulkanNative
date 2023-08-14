using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineViewportSwizzleStateCreateInfoNV
{
    public VkStructureType SType;
    public void* PNext;
    public VkPipelineViewportSwizzleStateCreateFlagsNV Flags;
    public uint ViewportCount;
    public VkViewportSwizzleNV* PViewportSwizzles;
}