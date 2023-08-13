using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineRasterizationStateStreamCreateInfoEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkPipelineRasterizationStateStreamCreateFlagsEXT Flags;
    public uint RasterizationStream;
}