using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkExtDirectfbSurfaceExtension
{
    private delegate* unmanaged[Cdecl]<VkInstance, VkDirectFBSurfaceCreateInfoEXT*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult> _vkCreateDirectFBSurfaceEXT;
    private delegate* unmanaged[Cdecl]<VkPhysicalDevice, uint, nint*, VkBool32> _vkGetPhysicalDeviceDirectFBPresentationSupportEXT;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkCreateDirectFBSurfaceEXT(VkInstance instance, VkDirectFBSurfaceCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
    {
        return _vkCreateDirectFBSurfaceEXT(instance, pCreateInfo, pAllocator, pSurface);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkBool32 VkGetPhysicalDeviceDirectFBPresentationSupportEXT(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, nint* dfb)
    {
        return _vkGetPhysicalDeviceDirectFBPresentationSupportEXT(physicalDevice, queueFamilyIndex, dfb);
    }
}