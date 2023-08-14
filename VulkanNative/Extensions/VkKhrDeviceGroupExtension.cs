namespace VulkanNative;

public unsafe class VkKhrDeviceGroupExtension
{
    public delegate* unmanaged[Cdecl]<VkDevice, uint, uint, uint, VkPeerMemoryFeatureFlags*, void> vkGetDeviceGroupPeerMemoryFeatures;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, void> vkCmdSetDeviceMask;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, uint, uint, uint, uint, uint, void> vkCmdDispatchBase;
    public delegate* unmanaged[Cdecl]<VkDevice, VkDeviceGroupPresentCapabilitiesKHR*, VkResult> vkGetDeviceGroupPresentCapabilitiesKHR;
    public delegate* unmanaged[Cdecl]<VkDevice, VkSurfaceKHR, VkDeviceGroupPresentModeFlagsKHR*, VkResult> vkGetDeviceGroupSurfacePresentModesKHR;
    public delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkSurfaceKHR, uint*, VkRect2D*, VkResult> vkGetPhysicalDevicePresentRectanglesKHR;
    public delegate* unmanaged[Cdecl]<VkDevice, VkAcquireNextImageInfoKHR*, uint*, VkResult> vkAcquireNextImage2KHR;
}