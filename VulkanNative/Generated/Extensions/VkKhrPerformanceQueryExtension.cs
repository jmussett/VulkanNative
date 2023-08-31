using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkKhrPerformanceQueryExtension
{
    private delegate* unmanaged[Cdecl]<VkPhysicalDevice, uint, uint*, VkPerformanceCounterKHR*, VkPerformanceCounterDescriptionKHR*, VkResult> _vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR;
    private delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkQueryPoolPerformanceCreateInfoKHR*, uint*, void> _vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR;
    private delegate* unmanaged[Cdecl]<VkDevice, VkAcquireProfilingLockInfoKHR*, VkResult> _vkAcquireProfilingLockKHR;
    private delegate* unmanaged[Cdecl]<VkDevice, void> _vkReleaseProfilingLockKHR;

    public VkKhrPerformanceQueryExtension(VkDevice device, IFunctionLoader loader)
    {
        _vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR = (delegate* unmanaged[Cdecl]<VkPhysicalDevice, uint, uint*, VkPerformanceCounterKHR*, VkPerformanceCounterDescriptionKHR*, VkResult>)loader.GetDeviceProcAddr(device, "vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR");
        _vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR = (delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkQueryPoolPerformanceCreateInfoKHR*, uint*, void>)loader.GetDeviceProcAddr(device, "vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR");
        _vkAcquireProfilingLockKHR = (delegate* unmanaged[Cdecl]<VkDevice, VkAcquireProfilingLockInfoKHR*, VkResult>)loader.GetDeviceProcAddr(device, "vkAcquireProfilingLockKHR");
        _vkReleaseProfilingLockKHR = (delegate* unmanaged[Cdecl]<VkDevice, void>)loader.GetDeviceProcAddr(device, "vkReleaseProfilingLockKHR");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, uint* pCounterCount, VkPerformanceCounterKHR* pCounters, VkPerformanceCounterDescriptionKHR* pCounterDescriptions)
    {
        return _vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(physicalDevice, queueFamilyIndex, pCounterCount, pCounters, pCounterDescriptions);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR(VkPhysicalDevice physicalDevice, VkQueryPoolPerformanceCreateInfoKHR* pPerformanceQueryCreateInfo, uint* pNumPasses)
    {
        _vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR(physicalDevice, pPerformanceQueryCreateInfo, pNumPasses);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult vkAcquireProfilingLockKHR(VkDevice device, VkAcquireProfilingLockInfoKHR* pInfo)
    {
        return _vkAcquireProfilingLockKHR(device, pInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void vkReleaseProfilingLockKHR(VkDevice device)
    {
        _vkReleaseProfilingLockKHR(device);
    }
}