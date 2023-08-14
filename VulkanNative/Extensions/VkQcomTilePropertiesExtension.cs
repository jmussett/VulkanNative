namespace VulkanNative;

public unsafe class VkQcomTilePropertiesExtension
{
    public delegate* unmanaged[Cdecl]<VkDevice, VkFramebuffer, uint*, VkTilePropertiesQCOM*, VkResult> vkGetFramebufferTilePropertiesQCOM;
    public delegate* unmanaged[Cdecl]<VkDevice, VkRenderingInfo*, VkTilePropertiesQCOM*, VkResult> vkGetDynamicRenderingTilePropertiesQCOM;
}