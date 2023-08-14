namespace VulkanNative;

public unsafe class VkExtDebugUtilsExtension
{
    public delegate* unmanaged[Cdecl]<VkDevice, VkDebugUtilsObjectNameInfoEXT*, VkResult> vkSetDebugUtilsObjectNameEXT;
    public delegate* unmanaged[Cdecl]<VkDevice, VkDebugUtilsObjectTagInfoEXT*, VkResult> vkSetDebugUtilsObjectTagEXT;
    public delegate* unmanaged[Cdecl]<VkQueue, VkDebugUtilsLabelEXT*, void> vkQueueBeginDebugUtilsLabelEXT;
    public delegate* unmanaged[Cdecl]<VkQueue, void> vkQueueEndDebugUtilsLabelEXT;
    public delegate* unmanaged[Cdecl]<VkQueue, VkDebugUtilsLabelEXT*, void> vkQueueInsertDebugUtilsLabelEXT;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDebugUtilsLabelEXT*, void> vkCmdBeginDebugUtilsLabelEXT;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, void> vkCmdEndDebugUtilsLabelEXT;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDebugUtilsLabelEXT*, void> vkCmdInsertDebugUtilsLabelEXT;
    public delegate* unmanaged[Cdecl]<VkInstance, VkDebugUtilsMessengerCreateInfoEXT*, VkAllocationCallbacks*, VkDebugUtilsMessengerEXT*, VkResult> vkCreateDebugUtilsMessengerEXT;
    public delegate* unmanaged[Cdecl]<VkInstance, VkDebugUtilsMessengerEXT, VkAllocationCallbacks*, void> vkDestroyDebugUtilsMessengerEXT;
    public delegate* unmanaged[Cdecl]<VkInstance, VkDebugUtilsMessageSeverityFlagsEXT, VkDebugUtilsMessageTypeFlagsEXT, VkDebugUtilsMessengerCallbackDataEXT*, void> vkSubmitDebugUtilsMessageEXT;
}