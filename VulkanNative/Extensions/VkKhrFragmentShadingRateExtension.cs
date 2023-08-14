namespace VulkanNative;

public unsafe class VkKhrFragmentShadingRateExtension
{
    public delegate* unmanaged[Cdecl]<VkPhysicalDevice, uint*, VkPhysicalDeviceFragmentShadingRateKHR*, VkResult> vkGetPhysicalDeviceFragmentShadingRatesKHR;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkExtent2D*, VkFragmentShadingRateCombinerOpKHR*, void> vkCmdSetFragmentShadingRateKHR;
}