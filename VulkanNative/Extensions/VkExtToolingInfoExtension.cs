using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkExtToolingInfoExtension
{
    private delegate* unmanaged[Cdecl]<VkPhysicalDevice, uint*, VkPhysicalDeviceToolProperties*, VkResult> _vkGetPhysicalDeviceToolProperties;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkGetPhysicalDeviceToolProperties(VkPhysicalDevice physicalDevice, uint* pToolCount, VkPhysicalDeviceToolProperties* pToolProperties)
    {
        return _vkGetPhysicalDeviceToolProperties(physicalDevice, pToolCount, pToolProperties);
    }
}