using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkExtDebugUtilsExtension
{
    private delegate* unmanaged[Cdecl]<VkDevice, VkDebugUtilsObjectNameInfoEXT*, VkResult> _vkSetDebugUtilsObjectNameEXT;
    private delegate* unmanaged[Cdecl]<VkDevice, VkDebugUtilsObjectTagInfoEXT*, VkResult> _vkSetDebugUtilsObjectTagEXT;
    private delegate* unmanaged[Cdecl]<VkQueue, VkDebugUtilsLabelEXT*, void> _vkQueueBeginDebugUtilsLabelEXT;
    private delegate* unmanaged[Cdecl]<VkQueue, void> _vkQueueEndDebugUtilsLabelEXT;
    private delegate* unmanaged[Cdecl]<VkQueue, VkDebugUtilsLabelEXT*, void> _vkQueueInsertDebugUtilsLabelEXT;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDebugUtilsLabelEXT*, void> _vkCmdBeginDebugUtilsLabelEXT;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, void> _vkCmdEndDebugUtilsLabelEXT;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDebugUtilsLabelEXT*, void> _vkCmdInsertDebugUtilsLabelEXT;
    private delegate* unmanaged[Cdecl]<VkInstance, VkDebugUtilsMessengerCreateInfoEXT*, VkAllocationCallbacks*, VkDebugUtilsMessengerEXT*, VkResult> _vkCreateDebugUtilsMessengerEXT;
    private delegate* unmanaged[Cdecl]<VkInstance, VkDebugUtilsMessengerEXT, VkAllocationCallbacks*, void> _vkDestroyDebugUtilsMessengerEXT;
    private delegate* unmanaged[Cdecl]<VkInstance, VkDebugUtilsMessageSeverityFlagsEXT, VkDebugUtilsMessageTypeFlagsEXT, VkDebugUtilsMessengerCallbackDataEXT*, void> _vkSubmitDebugUtilsMessageEXT;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkSetDebugUtilsObjectNameEXT(VkDevice device, VkDebugUtilsObjectNameInfoEXT* pNameInfo)
    {
        return _vkSetDebugUtilsObjectNameEXT(device, pNameInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkSetDebugUtilsObjectTagEXT(VkDevice device, VkDebugUtilsObjectTagInfoEXT* pTagInfo)
    {
        return _vkSetDebugUtilsObjectTagEXT(device, pTagInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkQueueBeginDebugUtilsLabelEXT(VkQueue queue, VkDebugUtilsLabelEXT* pLabelInfo)
    {
        _vkQueueBeginDebugUtilsLabelEXT(queue, pLabelInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkQueueEndDebugUtilsLabelEXT(VkQueue queue)
    {
        _vkQueueEndDebugUtilsLabelEXT(queue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkQueueInsertDebugUtilsLabelEXT(VkQueue queue, VkDebugUtilsLabelEXT* pLabelInfo)
    {
        _vkQueueInsertDebugUtilsLabelEXT(queue, pLabelInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdBeginDebugUtilsLabelEXT(VkCommandBuffer commandBuffer, VkDebugUtilsLabelEXT* pLabelInfo)
    {
        _vkCmdBeginDebugUtilsLabelEXT(commandBuffer, pLabelInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdEndDebugUtilsLabelEXT(VkCommandBuffer commandBuffer)
    {
        _vkCmdEndDebugUtilsLabelEXT(commandBuffer);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdInsertDebugUtilsLabelEXT(VkCommandBuffer commandBuffer, VkDebugUtilsLabelEXT* pLabelInfo)
    {
        _vkCmdInsertDebugUtilsLabelEXT(commandBuffer, pLabelInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkCreateDebugUtilsMessengerEXT(VkInstance instance, VkDebugUtilsMessengerCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDebugUtilsMessengerEXT* pMessenger)
    {
        return _vkCreateDebugUtilsMessengerEXT(instance, pCreateInfo, pAllocator, pMessenger);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkDestroyDebugUtilsMessengerEXT(VkInstance instance, VkDebugUtilsMessengerEXT messenger, VkAllocationCallbacks* pAllocator)
    {
        _vkDestroyDebugUtilsMessengerEXT(instance, messenger, pAllocator);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkSubmitDebugUtilsMessageEXT(VkInstance instance, VkDebugUtilsMessageSeverityFlagsEXT messageSeverity, VkDebugUtilsMessageTypeFlagsEXT messageTypes, VkDebugUtilsMessengerCallbackDataEXT* pCallbackData)
    {
        _vkSubmitDebugUtilsMessageEXT(instance, messageSeverity, messageTypes, pCallbackData);
    }
}