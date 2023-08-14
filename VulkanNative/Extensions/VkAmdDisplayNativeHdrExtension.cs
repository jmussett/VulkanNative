namespace VulkanNative;

public unsafe class VkAmdDisplayNativeHdrExtension
{
    public delegate* unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, VkBool32, void> vkSetLocalDimmingAMD;
}