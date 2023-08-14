using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkKhrExternalMemoryCapabilitiesExtension
{
    private delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkPhysicalDeviceExternalBufferInfo*, VkExternalBufferProperties*, void> _vkGetPhysicalDeviceExternalBufferProperties;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkGetPhysicalDeviceExternalBufferProperties(VkPhysicalDevice physicalDevice, VkPhysicalDeviceExternalBufferInfo* pExternalBufferInfo, VkExternalBufferProperties* pExternalBufferProperties)
    {
        _vkGetPhysicalDeviceExternalBufferProperties(physicalDevice, pExternalBufferInfo, pExternalBufferProperties);
    }
}