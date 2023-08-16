using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkKhrDisplayExtension
{
    private delegate* unmanaged[Cdecl]<VkPhysicalDevice, uint*, VkDisplayPropertiesKHR*, VkResult> _vkGetPhysicalDeviceDisplayPropertiesKHR;
    private delegate* unmanaged[Cdecl]<VkPhysicalDevice, uint*, VkDisplayPlanePropertiesKHR*, VkResult> _vkGetPhysicalDeviceDisplayPlanePropertiesKHR;
    private delegate* unmanaged[Cdecl]<VkPhysicalDevice, uint, uint*, VkDisplayKHR*, VkResult> _vkGetDisplayPlaneSupportedDisplaysKHR;
    private delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkDisplayKHR, uint*, VkDisplayModePropertiesKHR*, VkResult> _vkGetDisplayModePropertiesKHR;
    private delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkDisplayKHR, VkDisplayModeCreateInfoKHR*, VkAllocationCallbacks*, VkDisplayModeKHR*, VkResult> _vkCreateDisplayModeKHR;
    private delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkDisplayModeKHR, uint, VkDisplayPlaneCapabilitiesKHR*, VkResult> _vkGetDisplayPlaneCapabilitiesKHR;
    private delegate* unmanaged[Cdecl]<VkInstance, VkDisplaySurfaceCreateInfoKHR*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult> _vkCreateDisplayPlaneSurfaceKHR;

    public VkKhrDisplayExtension(VkInstance instance, IFunctionLoader loader)
    {
        _vkGetPhysicalDeviceDisplayPropertiesKHR = (delegate* unmanaged[Cdecl]<VkPhysicalDevice, uint*, VkDisplayPropertiesKHR*, VkResult>)loader.GetInstanceProcAddr(instance, "vkGetPhysicalDeviceDisplayPropertiesKHR");
        _vkGetPhysicalDeviceDisplayPlanePropertiesKHR = (delegate* unmanaged[Cdecl]<VkPhysicalDevice, uint*, VkDisplayPlanePropertiesKHR*, VkResult>)loader.GetInstanceProcAddr(instance, "vkGetPhysicalDeviceDisplayPlanePropertiesKHR");
        _vkGetDisplayPlaneSupportedDisplaysKHR = (delegate* unmanaged[Cdecl]<VkPhysicalDevice, uint, uint*, VkDisplayKHR*, VkResult>)loader.GetInstanceProcAddr(instance, "vkGetDisplayPlaneSupportedDisplaysKHR");
        _vkGetDisplayModePropertiesKHR = (delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkDisplayKHR, uint*, VkDisplayModePropertiesKHR*, VkResult>)loader.GetInstanceProcAddr(instance, "vkGetDisplayModePropertiesKHR");
        _vkCreateDisplayModeKHR = (delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkDisplayKHR, VkDisplayModeCreateInfoKHR*, VkAllocationCallbacks*, VkDisplayModeKHR*, VkResult>)loader.GetInstanceProcAddr(instance, "vkCreateDisplayModeKHR");
        _vkGetDisplayPlaneCapabilitiesKHR = (delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkDisplayModeKHR, uint, VkDisplayPlaneCapabilitiesKHR*, VkResult>)loader.GetInstanceProcAddr(instance, "vkGetDisplayPlaneCapabilitiesKHR");
        _vkCreateDisplayPlaneSurfaceKHR = (delegate* unmanaged[Cdecl]<VkInstance, VkDisplaySurfaceCreateInfoKHR*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult>)loader.GetInstanceProcAddr(instance, "vkCreateDisplayPlaneSurfaceKHR");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkGetPhysicalDeviceDisplayPropertiesKHR(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkDisplayPropertiesKHR* pProperties)
    {
        return _vkGetPhysicalDeviceDisplayPropertiesKHR(physicalDevice, pPropertyCount, pProperties);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkGetPhysicalDeviceDisplayPlanePropertiesKHR(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkDisplayPlanePropertiesKHR* pProperties)
    {
        return _vkGetPhysicalDeviceDisplayPlanePropertiesKHR(physicalDevice, pPropertyCount, pProperties);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkGetDisplayPlaneSupportedDisplaysKHR(VkPhysicalDevice physicalDevice, uint planeIndex, uint* pDisplayCount, VkDisplayKHR* pDisplays)
    {
        return _vkGetDisplayPlaneSupportedDisplaysKHR(physicalDevice, planeIndex, pDisplayCount, pDisplays);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkGetDisplayModePropertiesKHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, uint* pPropertyCount, VkDisplayModePropertiesKHR* pProperties)
    {
        return _vkGetDisplayModePropertiesKHR(physicalDevice, display, pPropertyCount, pProperties);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkCreateDisplayModeKHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, VkDisplayModeCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDisplayModeKHR* pMode)
    {
        return _vkCreateDisplayModeKHR(physicalDevice, display, pCreateInfo, pAllocator, pMode);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkGetDisplayPlaneCapabilitiesKHR(VkPhysicalDevice physicalDevice, VkDisplayModeKHR mode, uint planeIndex, VkDisplayPlaneCapabilitiesKHR* pCapabilities)
    {
        return _vkGetDisplayPlaneCapabilitiesKHR(physicalDevice, mode, planeIndex, pCapabilities);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkCreateDisplayPlaneSurfaceKHR(VkInstance instance, VkDisplaySurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
    {
        return _vkCreateDisplayPlaneSurfaceKHR(instance, pCreateInfo, pAllocator, pSurface);
    }
}