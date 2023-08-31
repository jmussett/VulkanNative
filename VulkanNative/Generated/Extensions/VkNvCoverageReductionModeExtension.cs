using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkNvCoverageReductionModeExtension
{
    private delegate* unmanaged[Cdecl]<VkPhysicalDevice, uint*, VkFramebufferMixedSamplesCombinationNV*, VkResult> _vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV;

    public VkNvCoverageReductionModeExtension(VkDevice device, IFunctionLoader loader)
    {
        _vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV = (delegate* unmanaged[Cdecl]<VkPhysicalDevice, uint*, VkFramebufferMixedSamplesCombinationNV*, VkResult>)loader.GetDeviceProcAddr(device, "vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV(VkPhysicalDevice physicalDevice, uint* pCombinationCount, VkFramebufferMixedSamplesCombinationNV* pCombinations)
    {
        return _vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV(physicalDevice, pCombinationCount, pCombinations);
    }
}