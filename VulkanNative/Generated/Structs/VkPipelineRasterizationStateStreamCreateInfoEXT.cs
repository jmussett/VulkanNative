using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineRasterizationStateStreamCreateInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkPipelineRasterizationStateStreamCreateFlagsEXT flags;
    public uint rasterizationStream;
}