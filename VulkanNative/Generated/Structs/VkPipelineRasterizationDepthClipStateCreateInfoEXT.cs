using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineRasterizationDepthClipStateCreateInfoEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkPipelineRasterizationDepthClipStateCreateFlagsEXT Flags;
    public VkBool32 DepthClipEnable;
}