using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkExtDirectModeDisplayExtension
{
    private delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkDisplayKHR, VkResult> _vkReleaseDisplayEXT;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkReleaseDisplayEXT(VkPhysicalDevice physicalDevice, VkDisplayKHR display)
    {
        return _vkReleaseDisplayEXT(physicalDevice, display);
    }
}