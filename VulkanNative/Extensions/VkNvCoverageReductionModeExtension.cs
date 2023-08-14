namespace VulkanNative;

public unsafe class VkNvCoverageReductionModeExtension
{
    public delegate* unmanaged[Cdecl]<VkPhysicalDevice, uint*, VkFramebufferMixedSamplesCombinationNV*, VkResult> vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV;
}