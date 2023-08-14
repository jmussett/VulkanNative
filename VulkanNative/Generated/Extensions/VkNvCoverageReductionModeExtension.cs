using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkNvCoverageReductionModeExtension
{
    private delegate* unmanaged[Cdecl]<VkPhysicalDevice, uint*, VkFramebufferMixedSamplesCombinationNV*, VkResult> _vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV(VkPhysicalDevice physicalDevice, uint* pCombinationCount, VkFramebufferMixedSamplesCombinationNV* pCombinations)
    {
        return _vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV(physicalDevice, pCombinationCount, pCombinations);
    }
}