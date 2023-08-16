using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkKhrVideoQueueExtension
{
    private delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkVideoProfileInfoKHR*, VkVideoCapabilitiesKHR*, VkResult> _vkGetPhysicalDeviceVideoCapabilitiesKHR;
    private delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkPhysicalDeviceVideoFormatInfoKHR*, uint*, VkVideoFormatPropertiesKHR*, VkResult> _vkGetPhysicalDeviceVideoFormatPropertiesKHR;
    private delegate* unmanaged[Cdecl]<VkDevice, VkVideoSessionCreateInfoKHR*, VkAllocationCallbacks*, VkVideoSessionKHR*, VkResult> _vkCreateVideoSessionKHR;
    private delegate* unmanaged[Cdecl]<VkDevice, VkVideoSessionKHR, VkAllocationCallbacks*, void> _vkDestroyVideoSessionKHR;
    private delegate* unmanaged[Cdecl]<VkDevice, VkVideoSessionKHR, uint*, VkVideoSessionMemoryRequirementsKHR*, VkResult> _vkGetVideoSessionMemoryRequirementsKHR;
    private delegate* unmanaged[Cdecl]<VkDevice, VkVideoSessionKHR, uint, VkBindVideoSessionMemoryInfoKHR*, VkResult> _vkBindVideoSessionMemoryKHR;
    private delegate* unmanaged[Cdecl]<VkDevice, VkVideoSessionParametersCreateInfoKHR*, VkAllocationCallbacks*, VkVideoSessionParametersKHR*, VkResult> _vkCreateVideoSessionParametersKHR;
    private delegate* unmanaged[Cdecl]<VkDevice, VkVideoSessionParametersKHR, VkVideoSessionParametersUpdateInfoKHR*, VkResult> _vkUpdateVideoSessionParametersKHR;
    private delegate* unmanaged[Cdecl]<VkDevice, VkVideoSessionParametersKHR, VkAllocationCallbacks*, void> _vkDestroyVideoSessionParametersKHR;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkVideoBeginCodingInfoKHR*, void> _vkCmdBeginVideoCodingKHR;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkVideoEndCodingInfoKHR*, void> _vkCmdEndVideoCodingKHR;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkVideoCodingControlInfoKHR*, void> _vkCmdControlVideoCodingKHR;

    public VkKhrVideoQueueExtension(VkDevice device, IFunctionLoader loader)
    {
        _vkGetPhysicalDeviceVideoCapabilitiesKHR = (delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkVideoProfileInfoKHR*, VkVideoCapabilitiesKHR*, VkResult>)loader.GetDeviceProcAddr(device, "vkGetPhysicalDeviceVideoCapabilitiesKHR");
        _vkGetPhysicalDeviceVideoFormatPropertiesKHR = (delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkPhysicalDeviceVideoFormatInfoKHR*, uint*, VkVideoFormatPropertiesKHR*, VkResult>)loader.GetDeviceProcAddr(device, "vkGetPhysicalDeviceVideoFormatPropertiesKHR");
        _vkCreateVideoSessionKHR = (delegate* unmanaged[Cdecl]<VkDevice, VkVideoSessionCreateInfoKHR*, VkAllocationCallbacks*, VkVideoSessionKHR*, VkResult>)loader.GetDeviceProcAddr(device, "vkCreateVideoSessionKHR");
        _vkDestroyVideoSessionKHR = (delegate* unmanaged[Cdecl]<VkDevice, VkVideoSessionKHR, VkAllocationCallbacks*, void>)loader.GetDeviceProcAddr(device, "vkDestroyVideoSessionKHR");
        _vkGetVideoSessionMemoryRequirementsKHR = (delegate* unmanaged[Cdecl]<VkDevice, VkVideoSessionKHR, uint*, VkVideoSessionMemoryRequirementsKHR*, VkResult>)loader.GetDeviceProcAddr(device, "vkGetVideoSessionMemoryRequirementsKHR");
        _vkBindVideoSessionMemoryKHR = (delegate* unmanaged[Cdecl]<VkDevice, VkVideoSessionKHR, uint, VkBindVideoSessionMemoryInfoKHR*, VkResult>)loader.GetDeviceProcAddr(device, "vkBindVideoSessionMemoryKHR");
        _vkCreateVideoSessionParametersKHR = (delegate* unmanaged[Cdecl]<VkDevice, VkVideoSessionParametersCreateInfoKHR*, VkAllocationCallbacks*, VkVideoSessionParametersKHR*, VkResult>)loader.GetDeviceProcAddr(device, "vkCreateVideoSessionParametersKHR");
        _vkUpdateVideoSessionParametersKHR = (delegate* unmanaged[Cdecl]<VkDevice, VkVideoSessionParametersKHR, VkVideoSessionParametersUpdateInfoKHR*, VkResult>)loader.GetDeviceProcAddr(device, "vkUpdateVideoSessionParametersKHR");
        _vkDestroyVideoSessionParametersKHR = (delegate* unmanaged[Cdecl]<VkDevice, VkVideoSessionParametersKHR, VkAllocationCallbacks*, void>)loader.GetDeviceProcAddr(device, "vkDestroyVideoSessionParametersKHR");
        _vkCmdBeginVideoCodingKHR = (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkVideoBeginCodingInfoKHR*, void>)loader.GetDeviceProcAddr(device, "vkCmdBeginVideoCodingKHR");
        _vkCmdEndVideoCodingKHR = (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkVideoEndCodingInfoKHR*, void>)loader.GetDeviceProcAddr(device, "vkCmdEndVideoCodingKHR");
        _vkCmdControlVideoCodingKHR = (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkVideoCodingControlInfoKHR*, void>)loader.GetDeviceProcAddr(device, "vkCmdControlVideoCodingKHR");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkGetPhysicalDeviceVideoCapabilitiesKHR(VkPhysicalDevice physicalDevice, VkVideoProfileInfoKHR* pVideoProfile, VkVideoCapabilitiesKHR* pCapabilities)
    {
        return _vkGetPhysicalDeviceVideoCapabilitiesKHR(physicalDevice, pVideoProfile, pCapabilities);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkGetPhysicalDeviceVideoFormatPropertiesKHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceVideoFormatInfoKHR* pVideoFormatInfo, uint* pVideoFormatPropertyCount, VkVideoFormatPropertiesKHR* pVideoFormatProperties)
    {
        return _vkGetPhysicalDeviceVideoFormatPropertiesKHR(physicalDevice, pVideoFormatInfo, pVideoFormatPropertyCount, pVideoFormatProperties);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkCreateVideoSessionKHR(VkDevice device, VkVideoSessionCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkVideoSessionKHR* pVideoSession)
    {
        return _vkCreateVideoSessionKHR(device, pCreateInfo, pAllocator, pVideoSession);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkDestroyVideoSessionKHR(VkDevice device, VkVideoSessionKHR videoSession, VkAllocationCallbacks* pAllocator)
    {
        _vkDestroyVideoSessionKHR(device, videoSession, pAllocator);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkGetVideoSessionMemoryRequirementsKHR(VkDevice device, VkVideoSessionKHR videoSession, uint* pMemoryRequirementsCount, VkVideoSessionMemoryRequirementsKHR* pMemoryRequirements)
    {
        return _vkGetVideoSessionMemoryRequirementsKHR(device, videoSession, pMemoryRequirementsCount, pMemoryRequirements);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkBindVideoSessionMemoryKHR(VkDevice device, VkVideoSessionKHR videoSession, uint bindSessionMemoryInfoCount, VkBindVideoSessionMemoryInfoKHR* pBindSessionMemoryInfos)
    {
        return _vkBindVideoSessionMemoryKHR(device, videoSession, bindSessionMemoryInfoCount, pBindSessionMemoryInfos);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkCreateVideoSessionParametersKHR(VkDevice device, VkVideoSessionParametersCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkVideoSessionParametersKHR* pVideoSessionParameters)
    {
        return _vkCreateVideoSessionParametersKHR(device, pCreateInfo, pAllocator, pVideoSessionParameters);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkUpdateVideoSessionParametersKHR(VkDevice device, VkVideoSessionParametersKHR videoSessionParameters, VkVideoSessionParametersUpdateInfoKHR* pUpdateInfo)
    {
        return _vkUpdateVideoSessionParametersKHR(device, videoSessionParameters, pUpdateInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkDestroyVideoSessionParametersKHR(VkDevice device, VkVideoSessionParametersKHR videoSessionParameters, VkAllocationCallbacks* pAllocator)
    {
        _vkDestroyVideoSessionParametersKHR(device, videoSessionParameters, pAllocator);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdBeginVideoCodingKHR(VkCommandBuffer commandBuffer, VkVideoBeginCodingInfoKHR* pBeginInfo)
    {
        _vkCmdBeginVideoCodingKHR(commandBuffer, pBeginInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdEndVideoCodingKHR(VkCommandBuffer commandBuffer, VkVideoEndCodingInfoKHR* pEndCodingInfo)
    {
        _vkCmdEndVideoCodingKHR(commandBuffer, pEndCodingInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdControlVideoCodingKHR(VkCommandBuffer commandBuffer, VkVideoCodingControlInfoKHR* pCodingControlInfo)
    {
        _vkCmdControlVideoCodingKHR(commandBuffer, pCodingControlInfo);
    }
}