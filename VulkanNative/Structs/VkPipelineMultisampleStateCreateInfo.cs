using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineMultisampleStateCreateInfo
{
    public VkStructureType sType;
    public void* pNext;
    public VkPipelineMultisampleStateCreateFlags flags;
    public VkSampleCountFlagBits rasterizationSamples;
    public VkBool32 sampleShadingEnable;
    public float minSampleShading;
    public VkSampleMask* pSampleMask;
    public VkBool32 alphaToCoverageEnable;
    public VkBool32 alphaToOneEnable;
}