using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkKhrFragmentShadingRateExtension
{
    private delegate* unmanaged[Cdecl]<VkPhysicalDevice, uint*, VkPhysicalDeviceFragmentShadingRateKHR*, VkResult> _vkGetPhysicalDeviceFragmentShadingRatesKHR;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkExtent2D*, VkFragmentShadingRateCombinerOpKHR*, void> _vkCmdSetFragmentShadingRateKHR;

    public VkKhrFragmentShadingRateExtension(VkDevice device, IVulkanLoader loader)
    {
        _vkGetPhysicalDeviceFragmentShadingRatesKHR = (delegate* unmanaged[Cdecl]<VkPhysicalDevice, uint*, VkPhysicalDeviceFragmentShadingRateKHR*, VkResult>)loader.GetDeviceProcAddr(device, "vkGetPhysicalDeviceFragmentShadingRatesKHR");
        _vkCmdSetFragmentShadingRateKHR = (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkExtent2D*, VkFragmentShadingRateCombinerOpKHR*, void>)loader.GetDeviceProcAddr(device, "vkCmdSetFragmentShadingRateKHR");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkGetPhysicalDeviceFragmentShadingRatesKHR(VkPhysicalDevice physicalDevice, uint* pFragmentShadingRateCount, VkPhysicalDeviceFragmentShadingRateKHR* pFragmentShadingRates)
    {
        return _vkGetPhysicalDeviceFragmentShadingRatesKHR(physicalDevice, pFragmentShadingRateCount, pFragmentShadingRates);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdSetFragmentShadingRateKHR(VkCommandBuffer commandBuffer, VkExtent2D* pFragmentSize, VkFragmentShadingRateCombinerOpKHR* combinerOps)
    {
        _vkCmdSetFragmentShadingRateKHR(commandBuffer, pFragmentSize, combinerOps);
    }
}