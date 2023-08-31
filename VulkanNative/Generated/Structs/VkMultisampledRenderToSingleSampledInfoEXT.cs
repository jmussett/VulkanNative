using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkMultisampledRenderToSingleSampledInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 multisampledRenderToSingleSampledEnable;
    public VkSampleCountFlags rasterizationSamples;
}