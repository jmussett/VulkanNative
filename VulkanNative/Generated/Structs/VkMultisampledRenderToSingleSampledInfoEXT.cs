using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkMultisampledRenderToSingleSampledInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 multisampledRenderToSingleSampledEnable;
    public VkSampleCountFlags rasterizationSamples;

    public VkMultisampledRenderToSingleSampledInfoEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_MULTISAMPLED_RENDER_TO_SINGLE_SAMPLED_INFO_EXT;
    }
}