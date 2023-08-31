using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceMultisampledRenderToSingleSampledFeaturesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 multisampledRenderToSingleSampled;

    public VkPhysicalDeviceMultisampledRenderToSingleSampledFeaturesEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTISAMPLED_RENDER_TO_SINGLE_SAMPLED_FEATURES_EXT;
    }
}