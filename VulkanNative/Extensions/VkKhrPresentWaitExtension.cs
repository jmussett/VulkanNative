namespace VulkanNative;

public unsafe class VkKhrPresentWaitExtension
{
    public delegate* unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, ulong, ulong, VkResult> vkWaitForPresentKHR;
}