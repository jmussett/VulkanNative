using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineViewportWScalingStateCreateInfoNV
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 viewportWScalingEnable;
    public uint viewportCount;
    public VkViewportWScalingNV* pViewportWScalings;
}