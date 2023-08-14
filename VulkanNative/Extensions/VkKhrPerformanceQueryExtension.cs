namespace VulkanNative;

public unsafe class VkKhrPerformanceQueryExtension
{
    public delegate* unmanaged[Cdecl]<VkPhysicalDevice, uint, uint*, VkPerformanceCounterKHR*, VkPerformanceCounterDescriptionKHR*, VkResult> vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR;
    public delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkQueryPoolPerformanceCreateInfoKHR*, uint*, void> vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR;
    public delegate* unmanaged[Cdecl]<VkDevice, VkAcquireProfilingLockInfoKHR*, VkResult> vkAcquireProfilingLockKHR;
    public delegate* unmanaged[Cdecl]<VkDevice, void> vkReleaseProfilingLockKHR;
}