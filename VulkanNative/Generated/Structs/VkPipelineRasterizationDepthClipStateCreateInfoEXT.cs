using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineRasterizationDepthClipStateCreateInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkPipelineRasterizationDepthClipStateCreateFlagsEXT flags;
    public VkBool32 depthClipEnable;
}