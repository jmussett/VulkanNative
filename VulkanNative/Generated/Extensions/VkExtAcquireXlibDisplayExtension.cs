using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkExtAcquireXlibDisplayExtension
{
    private delegate* unmanaged[Cdecl]<VkPhysicalDevice, nint*, VkDisplayKHR, VkResult> _vkAcquireXlibDisplayEXT;
    private delegate* unmanaged[Cdecl]<VkPhysicalDevice, nint*, nint, VkDisplayKHR*, VkResult> _vkGetRandROutputDisplayEXT;

    public VkExtAcquireXlibDisplayExtension(VkInstance instance, IFunctionLoader loader)
    {
        _vkAcquireXlibDisplayEXT = (delegate* unmanaged[Cdecl]<VkPhysicalDevice, nint*, VkDisplayKHR, VkResult>)loader.GetInstanceProcAddr(instance, "vkAcquireXlibDisplayEXT");
        _vkGetRandROutputDisplayEXT = (delegate* unmanaged[Cdecl]<VkPhysicalDevice, nint*, nint, VkDisplayKHR*, VkResult>)loader.GetInstanceProcAddr(instance, "vkGetRandROutputDisplayEXT");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult vkAcquireXlibDisplayEXT(VkPhysicalDevice physicalDevice, nint* dpy, VkDisplayKHR display)
    {
        return _vkAcquireXlibDisplayEXT(physicalDevice, dpy, display);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult vkGetRandROutputDisplayEXT(VkPhysicalDevice physicalDevice, nint* dpy, nint rrOutput, VkDisplayKHR* pDisplay)
    {
        return _vkGetRandROutputDisplayEXT(physicalDevice, dpy, rrOutput, pDisplay);
    }
}