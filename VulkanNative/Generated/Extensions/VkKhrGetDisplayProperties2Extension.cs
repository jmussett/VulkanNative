using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkKhrGetDisplayProperties2Extension
{
    private delegate* unmanaged[Cdecl]<VkPhysicalDevice, uint*, VkDisplayProperties2KHR*, VkResult> _vkGetPhysicalDeviceDisplayProperties2KHR;
    private delegate* unmanaged[Cdecl]<VkPhysicalDevice, uint*, VkDisplayPlaneProperties2KHR*, VkResult> _vkGetPhysicalDeviceDisplayPlaneProperties2KHR;
    private delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkDisplayKHR, uint*, VkDisplayModeProperties2KHR*, VkResult> _vkGetDisplayModeProperties2KHR;
    private delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkDisplayPlaneInfo2KHR*, VkDisplayPlaneCapabilities2KHR*, VkResult> _vkGetDisplayPlaneCapabilities2KHR;

    public VkKhrGetDisplayProperties2Extension(VkInstance instance, IFunctionLoader loader)
    {
        _vkGetPhysicalDeviceDisplayProperties2KHR = (delegate* unmanaged[Cdecl]<VkPhysicalDevice, uint*, VkDisplayProperties2KHR*, VkResult>)loader.GetInstanceProcAddr(instance, "vkGetPhysicalDeviceDisplayProperties2KHR");
        _vkGetPhysicalDeviceDisplayPlaneProperties2KHR = (delegate* unmanaged[Cdecl]<VkPhysicalDevice, uint*, VkDisplayPlaneProperties2KHR*, VkResult>)loader.GetInstanceProcAddr(instance, "vkGetPhysicalDeviceDisplayPlaneProperties2KHR");
        _vkGetDisplayModeProperties2KHR = (delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkDisplayKHR, uint*, VkDisplayModeProperties2KHR*, VkResult>)loader.GetInstanceProcAddr(instance, "vkGetDisplayModeProperties2KHR");
        _vkGetDisplayPlaneCapabilities2KHR = (delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkDisplayPlaneInfo2KHR*, VkDisplayPlaneCapabilities2KHR*, VkResult>)loader.GetInstanceProcAddr(instance, "vkGetDisplayPlaneCapabilities2KHR");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult vkGetPhysicalDeviceDisplayProperties2KHR(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkDisplayProperties2KHR* pProperties)
    {
        return _vkGetPhysicalDeviceDisplayProperties2KHR(physicalDevice, pPropertyCount, pProperties);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult vkGetPhysicalDeviceDisplayPlaneProperties2KHR(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkDisplayPlaneProperties2KHR* pProperties)
    {
        return _vkGetPhysicalDeviceDisplayPlaneProperties2KHR(physicalDevice, pPropertyCount, pProperties);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult vkGetDisplayModeProperties2KHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, uint* pPropertyCount, VkDisplayModeProperties2KHR* pProperties)
    {
        return _vkGetDisplayModeProperties2KHR(physicalDevice, display, pPropertyCount, pProperties);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult vkGetDisplayPlaneCapabilities2KHR(VkPhysicalDevice physicalDevice, VkDisplayPlaneInfo2KHR* pDisplayPlaneInfo, VkDisplayPlaneCapabilities2KHR* pCapabilities)
    {
        return _vkGetDisplayPlaneCapabilities2KHR(physicalDevice, pDisplayPlaneInfo, pCapabilities);
    }
}