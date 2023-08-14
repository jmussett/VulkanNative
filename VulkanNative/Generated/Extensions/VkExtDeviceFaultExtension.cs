using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkExtDeviceFaultExtension
{
    private delegate* unmanaged[Cdecl]<VkDevice, VkDeviceFaultCountsEXT*, VkDeviceFaultInfoEXT*, VkResult> _vkGetDeviceFaultInfoEXT;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkGetDeviceFaultInfoEXT(VkDevice device, VkDeviceFaultCountsEXT* pFaultCounts, VkDeviceFaultInfoEXT* pFaultInfo)
    {
        return _vkGetDeviceFaultInfoEXT(device, pFaultCounts, pFaultInfo);
    }
}