using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkExtAcquireXlibDisplayExtension
{
    private delegate* unmanaged[Cdecl]<VkPhysicalDevice, nint*, VkDisplayKHR, VkResult> _vkAcquireXlibDisplayEXT;
    private delegate* unmanaged[Cdecl]<VkPhysicalDevice, nint*, nint, VkDisplayKHR*, VkResult> _vkGetRandROutputDisplayEXT;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkAcquireXlibDisplayEXT(VkPhysicalDevice physicalDevice, nint* dpy, VkDisplayKHR display)
    {
        return _vkAcquireXlibDisplayEXT(physicalDevice, dpy, display);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkGetRandROutputDisplayEXT(VkPhysicalDevice physicalDevice, nint* dpy, nint rrOutput, VkDisplayKHR* pDisplay)
    {
        return _vkGetRandROutputDisplayEXT(physicalDevice, dpy, rrOutput, pDisplay);
    }
}