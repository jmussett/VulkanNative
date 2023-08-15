using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkExtDisplayControlExtension
{
    private delegate* unmanaged[Cdecl]<VkDevice, VkDisplayKHR, VkDisplayPowerInfoEXT*, VkResult> _vkDisplayPowerControlEXT;
    private delegate* unmanaged[Cdecl]<VkDevice, VkDeviceEventInfoEXT*, VkAllocationCallbacks*, VkFence*, VkResult> _vkRegisterDeviceEventEXT;
    private delegate* unmanaged[Cdecl]<VkDevice, VkDisplayKHR, VkDisplayEventInfoEXT*, VkAllocationCallbacks*, VkFence*, VkResult> _vkRegisterDisplayEventEXT;
    private delegate* unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, VkSurfaceCounterFlagsEXT, ulong*, VkResult> _vkGetSwapchainCounterEXT;

    public VkExtDisplayControlExtension(VkDevice device, IVulkanLoader loader)
    {
        _vkDisplayPowerControlEXT = (delegate* unmanaged[Cdecl]<VkDevice, VkDisplayKHR, VkDisplayPowerInfoEXT*, VkResult>)loader.GetDeviceProcAddr(device, "vkDisplayPowerControlEXT");
        _vkRegisterDeviceEventEXT = (delegate* unmanaged[Cdecl]<VkDevice, VkDeviceEventInfoEXT*, VkAllocationCallbacks*, VkFence*, VkResult>)loader.GetDeviceProcAddr(device, "vkRegisterDeviceEventEXT");
        _vkRegisterDisplayEventEXT = (delegate* unmanaged[Cdecl]<VkDevice, VkDisplayKHR, VkDisplayEventInfoEXT*, VkAllocationCallbacks*, VkFence*, VkResult>)loader.GetDeviceProcAddr(device, "vkRegisterDisplayEventEXT");
        _vkGetSwapchainCounterEXT = (delegate* unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, VkSurfaceCounterFlagsEXT, ulong*, VkResult>)loader.GetDeviceProcAddr(device, "vkGetSwapchainCounterEXT");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkDisplayPowerControlEXT(VkDevice device, VkDisplayKHR display, VkDisplayPowerInfoEXT* pDisplayPowerInfo)
    {
        return _vkDisplayPowerControlEXT(device, display, pDisplayPowerInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkRegisterDeviceEventEXT(VkDevice device, VkDeviceEventInfoEXT* pDeviceEventInfo, VkAllocationCallbacks* pAllocator, VkFence* pFence)
    {
        return _vkRegisterDeviceEventEXT(device, pDeviceEventInfo, pAllocator, pFence);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkRegisterDisplayEventEXT(VkDevice device, VkDisplayKHR display, VkDisplayEventInfoEXT* pDisplayEventInfo, VkAllocationCallbacks* pAllocator, VkFence* pFence)
    {
        return _vkRegisterDisplayEventEXT(device, display, pDisplayEventInfo, pAllocator, pFence);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkGetSwapchainCounterEXT(VkDevice device, VkSwapchainKHR swapchain, VkSurfaceCounterFlagsEXT counter, ulong* pCounterValue)
    {
        return _vkGetSwapchainCounterEXT(device, swapchain, counter, pCounterValue);
    }
}