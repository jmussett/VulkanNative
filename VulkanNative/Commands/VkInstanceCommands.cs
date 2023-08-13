namespace VulkanNative;

public unsafe class VkInstanceCommands
{
    public delegate* unmanaged[Cdecl]<VkInstance, VkAllocationCallbacks*, void> vkDestroyInstance;
    public delegate* unmanaged[Cdecl]<VkInstance, uint*, VkPhysicalDevice*, VkResult> vkEnumeratePhysicalDevices;
    public delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkPhysicalDeviceFeatures*, void> vkGetPhysicalDeviceFeatures;
    public delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkFormat, VkFormatProperties*, void> vkGetPhysicalDeviceFormatProperties;
    public delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkFormat, VkImageType, VkImageTiling, VkImageUsageFlags, VkImageCreateFlags, VkImageFormatProperties*, VkResult> vkGetPhysicalDeviceImageFormatProperties;
    public delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkPhysicalDeviceProperties*, void> vkGetPhysicalDeviceProperties;
    public delegate* unmanaged[Cdecl]<VkPhysicalDevice, uint*, VkQueueFamilyProperties*, void> vkGetPhysicalDeviceQueueFamilyProperties;
    public delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkPhysicalDeviceMemoryProperties*, void> vkGetPhysicalDeviceMemoryProperties;
    public delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkDeviceCreateInfo*, VkAllocationCallbacks*, VkDevice*, VkResult> vkCreateDevice;
    public delegate* unmanaged[Cdecl]<VkPhysicalDevice, char*, uint*, VkExtensionProperties*, VkResult> vkEnumerateDeviceExtensionProperties;
    public delegate* unmanaged[Cdecl]<VkPhysicalDevice, uint*, VkLayerProperties*, VkResult> vkEnumerateDeviceLayerProperties;
    public delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkFormat, VkImageType, VkSampleCountFlags, VkImageUsageFlags, VkImageTiling, uint*, VkSparseImageFormatProperties*, void> vkGetPhysicalDeviceSparseImageFormatProperties;
    public delegate* unmanaged[Cdecl]<VkInstance, uint*, VkPhysicalDeviceGroupProperties*, VkResult> vkEnumeratePhysicalDeviceGroups;
    public delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkPhysicalDeviceFeatures2*, void> vkGetPhysicalDeviceFeatures2;
    public delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkPhysicalDeviceProperties2*, void> vkGetPhysicalDeviceProperties2;
    public delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkFormat, VkFormatProperties2*, void> vkGetPhysicalDeviceFormatProperties2;
    public delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkPhysicalDeviceImageFormatInfo2*, VkImageFormatProperties2*, VkResult> vkGetPhysicalDeviceImageFormatProperties2;
    public delegate* unmanaged[Cdecl]<VkPhysicalDevice, uint*, VkQueueFamilyProperties2*, void> vkGetPhysicalDeviceQueueFamilyProperties2;
    public delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkPhysicalDeviceMemoryProperties2*, void> vkGetPhysicalDeviceMemoryProperties2;
    public delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkPhysicalDeviceSparseImageFormatInfo2*, uint*, VkSparseImageFormatProperties2*, void> vkGetPhysicalDeviceSparseImageFormatProperties2;
    public delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkPhysicalDeviceExternalBufferInfo*, VkExternalBufferProperties*, void> vkGetPhysicalDeviceExternalBufferProperties;
    public delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkPhysicalDeviceExternalFenceInfo*, VkExternalFenceProperties*, void> vkGetPhysicalDeviceExternalFenceProperties;
    public delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkPhysicalDeviceExternalSemaphoreInfo*, VkExternalSemaphoreProperties*, void> vkGetPhysicalDeviceExternalSemaphoreProperties;
    public delegate* unmanaged[Cdecl]<VkPhysicalDevice, uint*, VkPhysicalDeviceToolProperties*, VkResult> vkGetPhysicalDeviceToolProperties;
}