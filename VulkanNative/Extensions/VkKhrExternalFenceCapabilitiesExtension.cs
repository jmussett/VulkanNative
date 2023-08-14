using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkKhrExternalFenceCapabilitiesExtension
{
    private delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkPhysicalDeviceExternalFenceInfo*, VkExternalFenceProperties*, void> _vkGetPhysicalDeviceExternalFenceProperties;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkGetPhysicalDeviceExternalFenceProperties(VkPhysicalDevice physicalDevice, VkPhysicalDeviceExternalFenceInfo* pExternalFenceInfo, VkExternalFenceProperties* pExternalFenceProperties)
    {
        _vkGetPhysicalDeviceExternalFenceProperties(physicalDevice, pExternalFenceInfo, pExternalFenceProperties);
    }
}