using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkExtToolingInfoExtension
{
    private delegate* unmanaged[Cdecl]<VkPhysicalDevice, uint*, VkPhysicalDeviceToolProperties*, VkResult> _vkGetPhysicalDeviceToolProperties;

    public VkExtToolingInfoExtension(VkDevice device, IVulkanLoader loader)
    {
        _vkGetPhysicalDeviceToolProperties = (delegate* unmanaged[Cdecl]<VkPhysicalDevice, uint*, VkPhysicalDeviceToolProperties*, VkResult>)loader.GetDeviceProcAddr(device, "vkGetPhysicalDeviceToolProperties");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkGetPhysicalDeviceToolProperties(VkPhysicalDevice physicalDevice, uint* pToolCount, VkPhysicalDeviceToolProperties* pToolProperties)
    {
        return _vkGetPhysicalDeviceToolProperties(physicalDevice, pToolCount, pToolProperties);
    }
}