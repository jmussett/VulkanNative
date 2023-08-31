using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkKhrSharedPresentableImageExtension
{
    private delegate* unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, VkResult> _vkGetSwapchainStatusKHR;

    public VkKhrSharedPresentableImageExtension(VkDevice device, IFunctionLoader loader)
    {
        _vkGetSwapchainStatusKHR = (delegate* unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, VkResult>)loader.GetDeviceProcAddr(device, "vkGetSwapchainStatusKHR");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult vkGetSwapchainStatusKHR(VkDevice device, VkSwapchainKHR swapchain)
    {
        return _vkGetSwapchainStatusKHR(device, swapchain);
    }
}