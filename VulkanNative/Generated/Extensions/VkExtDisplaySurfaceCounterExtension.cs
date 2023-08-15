using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkExtDisplaySurfaceCounterExtension
{
    private delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkSurfaceKHR, VkSurfaceCapabilities2EXT*, VkResult> _vkGetPhysicalDeviceSurfaceCapabilities2EXT;

    public VkExtDisplaySurfaceCounterExtension(VkInstance instance, IVulkanLoader loader)
    {
        _vkGetPhysicalDeviceSurfaceCapabilities2EXT = (delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkSurfaceKHR, VkSurfaceCapabilities2EXT*, VkResult>)loader.GetInstanceProcAddr(instance, "vkGetPhysicalDeviceSurfaceCapabilities2EXT");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkGetPhysicalDeviceSurfaceCapabilities2EXT(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, VkSurfaceCapabilities2EXT* pSurfaceCapabilities)
    {
        return _vkGetPhysicalDeviceSurfaceCapabilities2EXT(physicalDevice, surface, pSurfaceCapabilities);
    }
}