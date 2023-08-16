using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkKhrCooperativeMatrixExtension
{
    private delegate* unmanaged[Cdecl]<VkPhysicalDevice, uint*, VkCooperativeMatrixPropertiesKHR*, VkResult> _vkGetPhysicalDeviceCooperativeMatrixPropertiesKHR;

    public VkKhrCooperativeMatrixExtension(VkDevice device, IFunctionLoader loader)
    {
        _vkGetPhysicalDeviceCooperativeMatrixPropertiesKHR = (delegate* unmanaged[Cdecl]<VkPhysicalDevice, uint*, VkCooperativeMatrixPropertiesKHR*, VkResult>)loader.GetDeviceProcAddr(device, "vkGetPhysicalDeviceCooperativeMatrixPropertiesKHR");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkGetPhysicalDeviceCooperativeMatrixPropertiesKHR(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkCooperativeMatrixPropertiesKHR* pProperties)
    {
        return _vkGetPhysicalDeviceCooperativeMatrixPropertiesKHR(physicalDevice, pPropertyCount, pProperties);
    }
}