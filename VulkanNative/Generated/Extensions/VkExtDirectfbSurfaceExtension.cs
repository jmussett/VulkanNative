using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkExtDirectfbSurfaceExtension
{
    private delegate* unmanaged[Cdecl]<VkInstance, VkDirectFBSurfaceCreateInfoEXT*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult> _vkCreateDirectFBSurfaceEXT;
    private delegate* unmanaged[Cdecl]<VkPhysicalDevice, uint, nint*, VkBool32> _vkGetPhysicalDeviceDirectFBPresentationSupportEXT;

    public VkExtDirectfbSurfaceExtension(VkInstance instance, IVulkanLoader loader)
    {
        _vkCreateDirectFBSurfaceEXT = (delegate* unmanaged[Cdecl]<VkInstance, VkDirectFBSurfaceCreateInfoEXT*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult>)loader.GetInstanceProcAddr(instance, "vkCreateDirectFBSurfaceEXT");
        _vkGetPhysicalDeviceDirectFBPresentationSupportEXT = (delegate* unmanaged[Cdecl]<VkPhysicalDevice, uint, nint*, VkBool32>)loader.GetInstanceProcAddr(instance, "vkGetPhysicalDeviceDirectFBPresentationSupportEXT");
    }

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