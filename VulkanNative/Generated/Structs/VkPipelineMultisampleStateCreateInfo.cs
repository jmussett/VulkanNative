using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineMultisampleStateCreateInfo
{
    public VkStructureType sType;
    public void* pNext;
    public VkPipelineMultisampleStateCreateFlags flags;
    public VkSampleCountFlags rasterizationSamples;
    public VkBool32 sampleShadingEnable;
    public float minSampleShading;
    public VkSampleMask* pSampleMask;
    public VkBool32 alphaToCoverageEnable;
    public VkBool32 alphaToOneEnable;

    public VkPipelineMultisampleStateCreateInfo()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_MULTISAMPLE_STATE_CREATE_INFO;
    }
}