namespace VulkanNative;

public unsafe class VkKhrVideoQueueExtension
{
    public delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkVideoProfileInfoKHR*, VkVideoCapabilitiesKHR*, VkResult> vkGetPhysicalDeviceVideoCapabilitiesKHR;
    public delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkPhysicalDeviceVideoFormatInfoKHR*, uint*, VkVideoFormatPropertiesKHR*, VkResult> vkGetPhysicalDeviceVideoFormatPropertiesKHR;
    public delegate* unmanaged[Cdecl]<VkDevice, VkVideoSessionCreateInfoKHR*, VkAllocationCallbacks*, VkVideoSessionKHR*, VkResult> vkCreateVideoSessionKHR;
    public delegate* unmanaged[Cdecl]<VkDevice, VkVideoSessionKHR, VkAllocationCallbacks*, void> vkDestroyVideoSessionKHR;
    public delegate* unmanaged[Cdecl]<VkDevice, VkVideoSessionKHR, uint*, VkVideoSessionMemoryRequirementsKHR*, VkResult> vkGetVideoSessionMemoryRequirementsKHR;
    public delegate* unmanaged[Cdecl]<VkDevice, VkVideoSessionKHR, uint, VkBindVideoSessionMemoryInfoKHR*, VkResult> vkBindVideoSessionMemoryKHR;
    public delegate* unmanaged[Cdecl]<VkDevice, VkVideoSessionParametersCreateInfoKHR*, VkAllocationCallbacks*, VkVideoSessionParametersKHR*, VkResult> vkCreateVideoSessionParametersKHR;
    public delegate* unmanaged[Cdecl]<VkDevice, VkVideoSessionParametersKHR, VkVideoSessionParametersUpdateInfoKHR*, VkResult> vkUpdateVideoSessionParametersKHR;
    public delegate* unmanaged[Cdecl]<VkDevice, VkVideoSessionParametersKHR, VkAllocationCallbacks*, void> vkDestroyVideoSessionParametersKHR;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkVideoBeginCodingInfoKHR*, void> vkCmdBeginVideoCodingKHR;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkVideoEndCodingInfoKHR*, void> vkCmdEndVideoCodingKHR;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkVideoCodingControlInfoKHR*, void> vkCmdControlVideoCodingKHR;
}