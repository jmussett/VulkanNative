using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkInstanceCommands
{
    private delegate* unmanaged[Cdecl]<VkInstance, VkAllocationCallbacks*, void> _vkDestroyInstance;
    private delegate* unmanaged[Cdecl]<VkInstance, uint*, VkPhysicalDevice*, VkResult> _vkEnumeratePhysicalDevices;
    private delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkPhysicalDeviceFeatures*, void> _vkGetPhysicalDeviceFeatures;
    private delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkFormat, VkFormatProperties*, void> _vkGetPhysicalDeviceFormatProperties;
    private delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkFormat, VkImageType, VkImageTiling, VkImageUsageFlags, VkImageCreateFlags, VkImageFormatProperties*, VkResult> _vkGetPhysicalDeviceImageFormatProperties;
    private delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkPhysicalDeviceProperties*, void> _vkGetPhysicalDeviceProperties;
    private delegate* unmanaged[Cdecl]<VkPhysicalDevice, uint*, VkQueueFamilyProperties*, void> _vkGetPhysicalDeviceQueueFamilyProperties;
    private delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkPhysicalDeviceMemoryProperties*, void> _vkGetPhysicalDeviceMemoryProperties;
    private delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkDeviceCreateInfo*, VkAllocationCallbacks*, VkDevice*, VkResult> _vkCreateDevice;
    private delegate* unmanaged[Cdecl]<VkPhysicalDevice, char*, uint*, VkExtensionProperties*, VkResult> _vkEnumerateDeviceExtensionProperties;
    private delegate* unmanaged[Cdecl]<VkPhysicalDevice, uint*, VkLayerProperties*, VkResult> _vkEnumerateDeviceLayerProperties;
    private delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkFormat, VkImageType, VkSampleCountFlags, VkImageUsageFlags, VkImageTiling, uint*, VkSparseImageFormatProperties*, void> _vkGetPhysicalDeviceSparseImageFormatProperties;
    private delegate* unmanaged[Cdecl]<VkInstance, uint*, VkPhysicalDeviceGroupProperties*, VkResult> _vkEnumeratePhysicalDeviceGroups;
    private delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkPhysicalDeviceFeatures2*, void> _vkGetPhysicalDeviceFeatures2;
    private delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkPhysicalDeviceProperties2*, void> _vkGetPhysicalDeviceProperties2;
    private delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkFormat, VkFormatProperties2*, void> _vkGetPhysicalDeviceFormatProperties2;
    private delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkPhysicalDeviceImageFormatInfo2*, VkImageFormatProperties2*, VkResult> _vkGetPhysicalDeviceImageFormatProperties2;
    private delegate* unmanaged[Cdecl]<VkPhysicalDevice, uint*, VkQueueFamilyProperties2*, void> _vkGetPhysicalDeviceQueueFamilyProperties2;
    private delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkPhysicalDeviceMemoryProperties2*, void> _vkGetPhysicalDeviceMemoryProperties2;
    private delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkPhysicalDeviceSparseImageFormatInfo2*, uint*, VkSparseImageFormatProperties2*, void> _vkGetPhysicalDeviceSparseImageFormatProperties2;
    private delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkPhysicalDeviceExternalBufferInfo*, VkExternalBufferProperties*, void> _vkGetPhysicalDeviceExternalBufferProperties;
    private delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkPhysicalDeviceExternalFenceInfo*, VkExternalFenceProperties*, void> _vkGetPhysicalDeviceExternalFenceProperties;
    private delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkPhysicalDeviceExternalSemaphoreInfo*, VkExternalSemaphoreProperties*, void> _vkGetPhysicalDeviceExternalSemaphoreProperties;
    private delegate* unmanaged[Cdecl]<VkPhysicalDevice, uint*, VkPhysicalDeviceToolProperties*, VkResult> _vkGetPhysicalDeviceToolProperties;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkDestroyInstance(VkInstance instance, VkAllocationCallbacks* pAllocator)
    {
        _vkDestroyInstance(instance, pAllocator);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkEnumeratePhysicalDevices(VkInstance instance, uint* pPhysicalDeviceCount, VkPhysicalDevice* pPhysicalDevices)
    {
        return _vkEnumeratePhysicalDevices(instance, pPhysicalDeviceCount, pPhysicalDevices);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkGetPhysicalDeviceFeatures(VkPhysicalDevice physicalDevice, VkPhysicalDeviceFeatures* pFeatures)
    {
        _vkGetPhysicalDeviceFeatures(physicalDevice, pFeatures);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkGetPhysicalDeviceFormatProperties(VkPhysicalDevice physicalDevice, VkFormat format, VkFormatProperties* pFormatProperties)
    {
        _vkGetPhysicalDeviceFormatProperties(physicalDevice, format, pFormatProperties);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkGetPhysicalDeviceImageFormatProperties(VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkImageTiling tiling, VkImageUsageFlags usage, VkImageCreateFlags flags, VkImageFormatProperties* pImageFormatProperties)
    {
        return _vkGetPhysicalDeviceImageFormatProperties(physicalDevice, format, type, tiling, usage, flags, pImageFormatProperties);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkGetPhysicalDeviceProperties(VkPhysicalDevice physicalDevice, VkPhysicalDeviceProperties* pProperties)
    {
        _vkGetPhysicalDeviceProperties(physicalDevice, pProperties);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkGetPhysicalDeviceQueueFamilyProperties(VkPhysicalDevice physicalDevice, uint* pQueueFamilyPropertyCount, VkQueueFamilyProperties* pQueueFamilyProperties)
    {
        _vkGetPhysicalDeviceQueueFamilyProperties(physicalDevice, pQueueFamilyPropertyCount, pQueueFamilyProperties);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkGetPhysicalDeviceMemoryProperties(VkPhysicalDevice physicalDevice, VkPhysicalDeviceMemoryProperties* pMemoryProperties)
    {
        _vkGetPhysicalDeviceMemoryProperties(physicalDevice, pMemoryProperties);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkCreateDevice(VkPhysicalDevice physicalDevice, VkDeviceCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDevice* pDevice)
    {
        return _vkCreateDevice(physicalDevice, pCreateInfo, pAllocator, pDevice);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkEnumerateDeviceExtensionProperties(VkPhysicalDevice physicalDevice, char* pLayerName, uint* pPropertyCount, VkExtensionProperties* pProperties)
    {
        return _vkEnumerateDeviceExtensionProperties(physicalDevice, pLayerName, pPropertyCount, pProperties);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkEnumerateDeviceLayerProperties(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkLayerProperties* pProperties)
    {
        return _vkEnumerateDeviceLayerProperties(physicalDevice, pPropertyCount, pProperties);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkGetPhysicalDeviceSparseImageFormatProperties(VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkSampleCountFlags samples, VkImageUsageFlags usage, VkImageTiling tiling, uint* pPropertyCount, VkSparseImageFormatProperties* pProperties)
    {
        _vkGetPhysicalDeviceSparseImageFormatProperties(physicalDevice, format, type, samples, usage, tiling, pPropertyCount, pProperties);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkEnumeratePhysicalDeviceGroups(VkInstance instance, uint* pPhysicalDeviceGroupCount, VkPhysicalDeviceGroupProperties* pPhysicalDeviceGroupProperties)
    {
        return _vkEnumeratePhysicalDeviceGroups(instance, pPhysicalDeviceGroupCount, pPhysicalDeviceGroupProperties);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkGetPhysicalDeviceFeatures2(VkPhysicalDevice physicalDevice, VkPhysicalDeviceFeatures2* pFeatures)
    {
        _vkGetPhysicalDeviceFeatures2(physicalDevice, pFeatures);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkGetPhysicalDeviceProperties2(VkPhysicalDevice physicalDevice, VkPhysicalDeviceProperties2* pProperties)
    {
        _vkGetPhysicalDeviceProperties2(physicalDevice, pProperties);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkGetPhysicalDeviceFormatProperties2(VkPhysicalDevice physicalDevice, VkFormat format, VkFormatProperties2* pFormatProperties)
    {
        _vkGetPhysicalDeviceFormatProperties2(physicalDevice, format, pFormatProperties);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkGetPhysicalDeviceImageFormatProperties2(VkPhysicalDevice physicalDevice, VkPhysicalDeviceImageFormatInfo2* pImageFormatInfo, VkImageFormatProperties2* pImageFormatProperties)
    {
        return _vkGetPhysicalDeviceImageFormatProperties2(physicalDevice, pImageFormatInfo, pImageFormatProperties);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkGetPhysicalDeviceQueueFamilyProperties2(VkPhysicalDevice physicalDevice, uint* pQueueFamilyPropertyCount, VkQueueFamilyProperties2* pQueueFamilyProperties)
    {
        _vkGetPhysicalDeviceQueueFamilyProperties2(physicalDevice, pQueueFamilyPropertyCount, pQueueFamilyProperties);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkGetPhysicalDeviceMemoryProperties2(VkPhysicalDevice physicalDevice, VkPhysicalDeviceMemoryProperties2* pMemoryProperties)
    {
        _vkGetPhysicalDeviceMemoryProperties2(physicalDevice, pMemoryProperties);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkGetPhysicalDeviceSparseImageFormatProperties2(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSparseImageFormatInfo2* pFormatInfo, uint* pPropertyCount, VkSparseImageFormatProperties2* pProperties)
    {
        _vkGetPhysicalDeviceSparseImageFormatProperties2(physicalDevice, pFormatInfo, pPropertyCount, pProperties);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkGetPhysicalDeviceExternalBufferProperties(VkPhysicalDevice physicalDevice, VkPhysicalDeviceExternalBufferInfo* pExternalBufferInfo, VkExternalBufferProperties* pExternalBufferProperties)
    {
        _vkGetPhysicalDeviceExternalBufferProperties(physicalDevice, pExternalBufferInfo, pExternalBufferProperties);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkGetPhysicalDeviceExternalFenceProperties(VkPhysicalDevice physicalDevice, VkPhysicalDeviceExternalFenceInfo* pExternalFenceInfo, VkExternalFenceProperties* pExternalFenceProperties)
    {
        _vkGetPhysicalDeviceExternalFenceProperties(physicalDevice, pExternalFenceInfo, pExternalFenceProperties);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkGetPhysicalDeviceExternalSemaphoreProperties(VkPhysicalDevice physicalDevice, VkPhysicalDeviceExternalSemaphoreInfo* pExternalSemaphoreInfo, VkExternalSemaphoreProperties* pExternalSemaphoreProperties)
    {
        _vkGetPhysicalDeviceExternalSemaphoreProperties(physicalDevice, pExternalSemaphoreInfo, pExternalSemaphoreProperties);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkGetPhysicalDeviceToolProperties(VkPhysicalDevice physicalDevice, uint* pToolCount, VkPhysicalDeviceToolProperties* pToolProperties)
    {
        return _vkGetPhysicalDeviceToolProperties(physicalDevice, pToolCount, pToolProperties);
    }
}