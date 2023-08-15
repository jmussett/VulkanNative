using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkExtDeviceFaultExtension
{
    private delegate* unmanaged[Cdecl]<VkDevice, VkDeviceFaultCountsEXT*, VkDeviceFaultInfoEXT*, VkResult> _vkGetDeviceFaultInfoEXT;

    public VkExtDeviceFaultExtension(VkDevice device, IVulkanLoader loader)
    {
        _vkGetDeviceFaultInfoEXT = (delegate* unmanaged[Cdecl]<VkDevice, VkDeviceFaultCountsEXT*, VkDeviceFaultInfoEXT*, VkResult>)loader.GetDeviceProcAddr(device, "vkGetDeviceFaultInfoEXT");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkGetDeviceFaultInfoEXT(VkDevice device, VkDeviceFaultCountsEXT* pFaultCounts, VkDeviceFaultInfoEXT* pFaultInfo)
    {
        return _vkGetDeviceFaultInfoEXT(device, pFaultCounts, pFaultInfo);
    }
}