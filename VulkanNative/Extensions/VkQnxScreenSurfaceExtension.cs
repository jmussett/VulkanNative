using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkQnxScreenSurfaceExtension
{
    private delegate* unmanaged[Cdecl]<VkInstance, VkScreenSurfaceCreateInfoQNX*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult> _vkCreateScreenSurfaceQNX;
    private delegate* unmanaged[Cdecl]<VkPhysicalDevice, uint, nint*, VkBool32> _vkGetPhysicalDeviceScreenPresentationSupportQNX;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkCreateScreenSurfaceQNX(VkInstance instance, VkScreenSurfaceCreateInfoQNX* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
    {
        return _vkCreateScreenSurfaceQNX(instance, pCreateInfo, pAllocator, pSurface);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkBool32 VkGetPhysicalDeviceScreenPresentationSupportQNX(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, nint* window)
    {
        return _vkGetPhysicalDeviceScreenPresentationSupportQNX(physicalDevice, queueFamilyIndex, window);
    }
}