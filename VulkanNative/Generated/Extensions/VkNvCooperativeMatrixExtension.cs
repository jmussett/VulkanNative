using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkNvCooperativeMatrixExtension
{
    private delegate* unmanaged[Cdecl]<VkPhysicalDevice, uint*, VkCooperativeMatrixPropertiesNV*, VkResult> _vkGetPhysicalDeviceCooperativeMatrixPropertiesNV;

    public VkNvCooperativeMatrixExtension(VkDevice device, IFunctionLoader loader)
    {
        _vkGetPhysicalDeviceCooperativeMatrixPropertiesNV = (delegate* unmanaged[Cdecl]<VkPhysicalDevice, uint*, VkCooperativeMatrixPropertiesNV*, VkResult>)loader.GetDeviceProcAddr(device, "vkGetPhysicalDeviceCooperativeMatrixPropertiesNV");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult vkGetPhysicalDeviceCooperativeMatrixPropertiesNV(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkCooperativeMatrixPropertiesNV* pProperties)
    {
        return _vkGetPhysicalDeviceCooperativeMatrixPropertiesNV(physicalDevice, pPropertyCount, pProperties);
    }
}