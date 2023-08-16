using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkKhrExternalSemaphoreCapabilitiesExtension
{
    private delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkPhysicalDeviceExternalSemaphoreInfo*, VkExternalSemaphoreProperties*, void> _vkGetPhysicalDeviceExternalSemaphoreProperties;

    public VkKhrExternalSemaphoreCapabilitiesExtension(VkInstance instance, IFunctionLoader loader)
    {
        _vkGetPhysicalDeviceExternalSemaphoreProperties = (delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkPhysicalDeviceExternalSemaphoreInfo*, VkExternalSemaphoreProperties*, void>)loader.GetInstanceProcAddr(instance, "vkGetPhysicalDeviceExternalSemaphoreProperties");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkGetPhysicalDeviceExternalSemaphoreProperties(VkPhysicalDevice physicalDevice, VkPhysicalDeviceExternalSemaphoreInfo* pExternalSemaphoreInfo, VkExternalSemaphoreProperties* pExternalSemaphoreProperties)
    {
        _vkGetPhysicalDeviceExternalSemaphoreProperties(physicalDevice, pExternalSemaphoreInfo, pExternalSemaphoreProperties);
    }
}