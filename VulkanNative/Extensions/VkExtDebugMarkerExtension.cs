namespace VulkanNative;

public unsafe class VkExtDebugMarkerExtension
{
    public delegate* unmanaged[Cdecl]<VkDevice, VkDebugMarkerObjectTagInfoEXT*, VkResult> vkDebugMarkerSetObjectTagEXT;
    public delegate* unmanaged[Cdecl]<VkDevice, VkDebugMarkerObjectNameInfoEXT*, VkResult> vkDebugMarkerSetObjectNameEXT;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDebugMarkerMarkerInfoEXT*, void> vkCmdDebugMarkerBeginEXT;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, void> vkCmdDebugMarkerEndEXT;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDebugMarkerMarkerInfoEXT*, void> vkCmdDebugMarkerInsertEXT;
}