namespace VulkanNative;

public unsafe class VkExtDisplayControlExtension
{
    public delegate* unmanaged[Cdecl]<VkDevice, VkDisplayKHR, VkDisplayPowerInfoEXT*, VkResult> vkDisplayPowerControlEXT;
    public delegate* unmanaged[Cdecl]<VkDevice, VkDeviceEventInfoEXT*, VkAllocationCallbacks*, VkFence*, VkResult> vkRegisterDeviceEventEXT;
    public delegate* unmanaged[Cdecl]<VkDevice, VkDisplayKHR, VkDisplayEventInfoEXT*, VkAllocationCallbacks*, VkFence*, VkResult> vkRegisterDisplayEventEXT;
    public delegate* unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, VkSurfaceCounterFlagsEXT, ulong*, VkResult> vkGetSwapchainCounterEXT;
}