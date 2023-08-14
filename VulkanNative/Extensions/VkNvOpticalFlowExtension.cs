namespace VulkanNative;

public unsafe class VkNvOpticalFlowExtension
{
    public delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkOpticalFlowImageFormatInfoNV*, uint*, VkOpticalFlowImageFormatPropertiesNV*, VkResult> vkGetPhysicalDeviceOpticalFlowImageFormatsNV;
    public delegate* unmanaged[Cdecl]<VkDevice, VkOpticalFlowSessionCreateInfoNV*, VkAllocationCallbacks*, VkOpticalFlowSessionNV*, VkResult> vkCreateOpticalFlowSessionNV;
    public delegate* unmanaged[Cdecl]<VkDevice, VkOpticalFlowSessionNV, VkAllocationCallbacks*, void> vkDestroyOpticalFlowSessionNV;
    public delegate* unmanaged[Cdecl]<VkDevice, VkOpticalFlowSessionNV, VkOpticalFlowSessionBindingPointNV, VkImageView, VkImageLayout, VkResult> vkBindOpticalFlowSessionImageNV;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkOpticalFlowSessionNV, VkOpticalFlowExecuteInfoNV*, void> vkCmdOpticalFlowExecuteNV;
}