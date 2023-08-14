using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkKhrPresentWaitExtension
{
    private delegate* unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, ulong, ulong, VkResult> _vkWaitForPresentKHR;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkWaitForPresentKHR(VkDevice device, VkSwapchainKHR swapchain, ulong presentId, ulong timeout)
    {
        return _vkWaitForPresentKHR(device, swapchain, presentId, timeout);
    }
}