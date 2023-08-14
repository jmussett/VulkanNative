using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineViewportWScalingStateCreateInfoNV
{
    public VkStructureType SType;
    public void* PNext;
    public VkBool32 ViewportWScalingEnable;
    public uint ViewportCount;
    public VkViewportWScalingNV* PViewportWScalings;
}