using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkKhrDisplaySwapchainExtension
{
    private delegate* unmanaged[Cdecl]<VkDevice, uint, VkSwapchainCreateInfoKHR*, VkAllocationCallbacks*, VkSwapchainKHR*, VkResult> _vkCreateSharedSwapchainsKHR;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkCreateSharedSwapchainsKHR(VkDevice device, uint swapchainCount, VkSwapchainCreateInfoKHR* pCreateInfos, VkAllocationCallbacks* pAllocator, VkSwapchainKHR* pSwapchains)
    {
        return _vkCreateSharedSwapchainsKHR(device, swapchainCount, pCreateInfos, pAllocator, pSwapchains);
    }
}