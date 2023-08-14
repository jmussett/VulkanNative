using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkExtAcquireDrmDisplayExtension
{
    private delegate* unmanaged[Cdecl]<VkPhysicalDevice, int, VkDisplayKHR, VkResult> _vkAcquireDrmDisplayEXT;
    private delegate* unmanaged[Cdecl]<VkPhysicalDevice, int, uint, VkDisplayKHR*, VkResult> _vkGetDrmDisplayEXT;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkAcquireDrmDisplayEXT(VkPhysicalDevice physicalDevice, int drmFd, VkDisplayKHR display)
    {
        return _vkAcquireDrmDisplayEXT(physicalDevice, drmFd, display);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkGetDrmDisplayEXT(VkPhysicalDevice physicalDevice, int drmFd, uint connectorId, VkDisplayKHR* display)
    {
        return _vkGetDrmDisplayEXT(physicalDevice, drmFd, connectorId, display);
    }
}