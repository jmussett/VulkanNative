using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkNvOpticalFlowExtension
{
    private delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkOpticalFlowImageFormatInfoNV*, uint*, VkOpticalFlowImageFormatPropertiesNV*, VkResult> _vkGetPhysicalDeviceOpticalFlowImageFormatsNV;
    private delegate* unmanaged[Cdecl]<VkDevice, VkOpticalFlowSessionCreateInfoNV*, VkAllocationCallbacks*, VkOpticalFlowSessionNV*, VkResult> _vkCreateOpticalFlowSessionNV;
    private delegate* unmanaged[Cdecl]<VkDevice, VkOpticalFlowSessionNV, VkAllocationCallbacks*, void> _vkDestroyOpticalFlowSessionNV;
    private delegate* unmanaged[Cdecl]<VkDevice, VkOpticalFlowSessionNV, VkOpticalFlowSessionBindingPointNV, VkImageView, VkImageLayout, VkResult> _vkBindOpticalFlowSessionImageNV;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkOpticalFlowSessionNV, VkOpticalFlowExecuteInfoNV*, void> _vkCmdOpticalFlowExecuteNV;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkGetPhysicalDeviceOpticalFlowImageFormatsNV(VkPhysicalDevice physicalDevice, VkOpticalFlowImageFormatInfoNV* pOpticalFlowImageFormatInfo, uint* pFormatCount, VkOpticalFlowImageFormatPropertiesNV* pImageFormatProperties)
    {
        return _vkGetPhysicalDeviceOpticalFlowImageFormatsNV(physicalDevice, pOpticalFlowImageFormatInfo, pFormatCount, pImageFormatProperties);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkCreateOpticalFlowSessionNV(VkDevice device, VkOpticalFlowSessionCreateInfoNV* pCreateInfo, VkAllocationCallbacks* pAllocator, VkOpticalFlowSessionNV* pSession)
    {
        return _vkCreateOpticalFlowSessionNV(device, pCreateInfo, pAllocator, pSession);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkDestroyOpticalFlowSessionNV(VkDevice device, VkOpticalFlowSessionNV session, VkAllocationCallbacks* pAllocator)
    {
        _vkDestroyOpticalFlowSessionNV(device, session, pAllocator);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkBindOpticalFlowSessionImageNV(VkDevice device, VkOpticalFlowSessionNV session, VkOpticalFlowSessionBindingPointNV bindingPoint, VkImageView view, VkImageLayout layout)
    {
        return _vkBindOpticalFlowSessionImageNV(device, session, bindingPoint, view, layout);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdOpticalFlowExecuteNV(VkCommandBuffer commandBuffer, VkOpticalFlowSessionNV session, VkOpticalFlowExecuteInfoNV* pExecuteInfo)
    {
        _vkCmdOpticalFlowExecuteNV(commandBuffer, session, pExecuteInfo);
    }
}