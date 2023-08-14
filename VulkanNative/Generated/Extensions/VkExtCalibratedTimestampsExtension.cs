﻿using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkExtCalibratedTimestampsExtension
{
    private delegate* unmanaged[Cdecl]<VkPhysicalDevice, uint*, VkTimeDomainEXT*, VkResult> _vkGetPhysicalDeviceCalibrateableTimeDomainsEXT;
    private delegate* unmanaged[Cdecl]<VkDevice, uint, VkCalibratedTimestampInfoEXT*, ulong*, ulong*, VkResult> _vkGetCalibratedTimestampsEXT;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkGetPhysicalDeviceCalibrateableTimeDomainsEXT(VkPhysicalDevice physicalDevice, uint* pTimeDomainCount, VkTimeDomainEXT* pTimeDomains)
    {
        return _vkGetPhysicalDeviceCalibrateableTimeDomainsEXT(physicalDevice, pTimeDomainCount, pTimeDomains);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkGetCalibratedTimestampsEXT(VkDevice device, uint timestampCount, VkCalibratedTimestampInfoEXT* pTimestampInfos, ulong* pTimestamps, ulong* pMaxDeviation)
    {
        return _vkGetCalibratedTimestampsEXT(device, timestampCount, pTimestampInfos, pTimestamps, pMaxDeviation);
    }
}