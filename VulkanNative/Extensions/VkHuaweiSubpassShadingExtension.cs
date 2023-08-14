namespace VulkanNative;

public unsafe class VkHuaweiSubpassShadingExtension
{
    public delegate* unmanaged[Cdecl]<VkDevice, VkRenderPass, VkExtent2D*, VkResult> vkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, void> vkCmdSubpassShadingHUAWEI;
}