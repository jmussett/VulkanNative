namespace VulkanNative;

public unsafe class VkKhrGetPhysicalDeviceProperties2Extension
{
    public delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkPhysicalDeviceFeatures2*, void> vkGetPhysicalDeviceFeatures2;
    public delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkPhysicalDeviceProperties2*, void> vkGetPhysicalDeviceProperties2;
    public delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkFormat, VkFormatProperties2*, void> vkGetPhysicalDeviceFormatProperties2;
    public delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkPhysicalDeviceImageFormatInfo2*, VkImageFormatProperties2*, VkResult> vkGetPhysicalDeviceImageFormatProperties2;
    public delegate* unmanaged[Cdecl]<VkPhysicalDevice, uint*, VkQueueFamilyProperties2*, void> vkGetPhysicalDeviceQueueFamilyProperties2;
    public delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkPhysicalDeviceMemoryProperties2*, void> vkGetPhysicalDeviceMemoryProperties2;
    public delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkPhysicalDeviceSparseImageFormatInfo2*, uint*, VkSparseImageFormatProperties2*, void> vkGetPhysicalDeviceSparseImageFormatProperties2;
}