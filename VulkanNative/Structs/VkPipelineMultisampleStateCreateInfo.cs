using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineMultisampleStateCreateInfo
{
    public VkStructureType SType;
    public void* PNext;
    public VkPipelineMultisampleStateCreateFlags Flags;
    public VkSampleCountFlags RasterizationSamples;
    public VkBool32 SampleShadingEnable;
    public float MinSampleShading;
    public VkSampleMask* PSampleMask;
    public VkBool32 AlphaToCoverageEnable;
    public VkBool32 AlphaToOneEnable;
}