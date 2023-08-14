namespace VulkanNative;

public unsafe class VkKhrSharedPresentableImageExtension
{
    public delegate* unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, VkResult> vkGetSwapchainStatusKHR;
}