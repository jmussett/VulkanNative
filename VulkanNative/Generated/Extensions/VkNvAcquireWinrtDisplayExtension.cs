using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkNvAcquireWinrtDisplayExtension
{
    private delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkDisplayKHR, VkResult> _vkAcquireWinrtDisplayNV;
    private delegate* unmanaged[Cdecl]<VkPhysicalDevice, uint, VkDisplayKHR*, VkResult> _vkGetWinrtDisplayNV;

    public VkNvAcquireWinrtDisplayExtension(VkDevice device, IVulkanLoader loader)
    {
        _vkAcquireWinrtDisplayNV = (delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkDisplayKHR, VkResult>)loader.GetDeviceProcAddr(device, "vkAcquireWinrtDisplayNV");
        _vkGetWinrtDisplayNV = (delegate* unmanaged[Cdecl]<VkPhysicalDevice, uint, VkDisplayKHR*, VkResult>)loader.GetDeviceProcAddr(device, "vkGetWinrtDisplayNV");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkAcquireWinrtDisplayNV(VkPhysicalDevice physicalDevice, VkDisplayKHR display)
    {
        return _vkAcquireWinrtDisplayNV(physicalDevice, display);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkGetWinrtDisplayNV(VkPhysicalDevice physicalDevice, uint deviceRelativeId, VkDisplayKHR* pDisplay)
    {
        return _vkGetWinrtDisplayNV(physicalDevice, deviceRelativeId, pDisplay);
    }
}