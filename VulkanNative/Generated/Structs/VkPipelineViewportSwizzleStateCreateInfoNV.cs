using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineViewportSwizzleStateCreateInfoNV
{
    public VkStructureType sType;
    public void* pNext;
    public VkPipelineViewportSwizzleStateCreateFlagsNV flags;
    public uint viewportCount;
    public VkViewportSwizzleNV* pViewportSwizzles;
}