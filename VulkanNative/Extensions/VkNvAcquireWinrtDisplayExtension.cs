using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkNvAcquireWinrtDisplayExtension
{
    private delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkDisplayKHR, VkResult> _vkAcquireWinrtDisplayNV;
    private delegate* unmanaged[Cdecl]<VkPhysicalDevice, uint, VkDisplayKHR*, VkResult> _vkGetWinrtDisplayNV;

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