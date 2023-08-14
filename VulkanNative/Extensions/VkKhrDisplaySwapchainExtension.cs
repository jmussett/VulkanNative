namespace VulkanNative;

public unsafe class VkKhrDisplaySwapchainExtension
{
    public delegate* unmanaged[Cdecl]<VkDevice, uint, VkSwapchainCreateInfoKHR*, VkSwapchainCreateInfoKHR*, VkAllocationCallbacks*, VkSwapchainKHR*, VkResult> vkCreateSharedSwapchainsKHR;
}