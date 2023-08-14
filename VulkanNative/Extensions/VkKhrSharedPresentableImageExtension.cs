using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkKhrSharedPresentableImageExtension
{
    private delegate* unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, VkResult> _vkGetSwapchainStatusKHR;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkGetSwapchainStatusKHR(VkDevice device, VkSwapchainKHR swapchain)
    {
        return _vkGetSwapchainStatusKHR(device, swapchain);
    }
}