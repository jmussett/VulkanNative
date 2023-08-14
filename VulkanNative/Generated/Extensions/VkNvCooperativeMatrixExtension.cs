using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkNvCooperativeMatrixExtension
{
    private delegate* unmanaged[Cdecl]<VkPhysicalDevice, uint*, VkCooperativeMatrixPropertiesNV*, VkResult> _vkGetPhysicalDeviceCooperativeMatrixPropertiesNV;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkGetPhysicalDeviceCooperativeMatrixPropertiesNV(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkCooperativeMatrixPropertiesNV* pProperties)
    {
        return _vkGetPhysicalDeviceCooperativeMatrixPropertiesNV(physicalDevice, pPropertyCount, pProperties);
    }
}