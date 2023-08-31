using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkKhrGetPhysicalDeviceProperties2Extension
{
    private delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkPhysicalDeviceFeatures2*, void> _vkGetPhysicalDeviceFeatures2;
    private delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkPhysicalDeviceProperties2*, void> _vkGetPhysicalDeviceProperties2;
    private delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkFormat, VkFormatProperties2*, void> _vkGetPhysicalDeviceFormatProperties2;
    private delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkPhysicalDeviceImageFormatInfo2*, VkImageFormatProperties2*, VkResult> _vkGetPhysicalDeviceImageFormatProperties2;
    private delegate* unmanaged[Cdecl]<VkPhysicalDevice, uint*, VkQueueFamilyProperties2*, void> _vkGetPhysicalDeviceQueueFamilyProperties2;
    private delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkPhysicalDeviceMemoryProperties2*, void> _vkGetPhysicalDeviceMemoryProperties2;
    private delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkPhysicalDeviceSparseImageFormatInfo2*, uint*, VkSparseImageFormatProperties2*, void> _vkGetPhysicalDeviceSparseImageFormatProperties2;

    public VkKhrGetPhysicalDeviceProperties2Extension(VkInstance instance, IFunctionLoader loader)
    {
        _vkGetPhysicalDeviceFeatures2 = (delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkPhysicalDeviceFeatures2*, void>)loader.GetInstanceProcAddr(instance, "vkGetPhysicalDeviceFeatures2");
        _vkGetPhysicalDeviceProperties2 = (delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkPhysicalDeviceProperties2*, void>)loader.GetInstanceProcAddr(instance, "vkGetPhysicalDeviceProperties2");
        _vkGetPhysicalDeviceFormatProperties2 = (delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkFormat, VkFormatProperties2*, void>)loader.GetInstanceProcAddr(instance, "vkGetPhysicalDeviceFormatProperties2");
        _vkGetPhysicalDeviceImageFormatProperties2 = (delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkPhysicalDeviceImageFormatInfo2*, VkImageFormatProperties2*, VkResult>)loader.GetInstanceProcAddr(instance, "vkGetPhysicalDeviceImageFormatProperties2");
        _vkGetPhysicalDeviceQueueFamilyProperties2 = (delegate* unmanaged[Cdecl]<VkPhysicalDevice, uint*, VkQueueFamilyProperties2*, void>)loader.GetInstanceProcAddr(instance, "vkGetPhysicalDeviceQueueFamilyProperties2");
        _vkGetPhysicalDeviceMemoryProperties2 = (delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkPhysicalDeviceMemoryProperties2*, void>)loader.GetInstanceProcAddr(instance, "vkGetPhysicalDeviceMemoryProperties2");
        _vkGetPhysicalDeviceSparseImageFormatProperties2 = (delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkPhysicalDeviceSparseImageFormatInfo2*, uint*, VkSparseImageFormatProperties2*, void>)loader.GetInstanceProcAddr(instance, "vkGetPhysicalDeviceSparseImageFormatProperties2");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void vkGetPhysicalDeviceFeatures2(VkPhysicalDevice physicalDevice, VkPhysicalDeviceFeatures2* pFeatures)
    {
        _vkGetPhysicalDeviceFeatures2(physicalDevice, pFeatures);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void vkGetPhysicalDeviceProperties2(VkPhysicalDevice physicalDevice, VkPhysicalDeviceProperties2* pProperties)
    {
        _vkGetPhysicalDeviceProperties2(physicalDevice, pProperties);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void vkGetPhysicalDeviceFormatProperties2(VkPhysicalDevice physicalDevice, VkFormat format, VkFormatProperties2* pFormatProperties)
    {
        _vkGetPhysicalDeviceFormatProperties2(physicalDevice, format, pFormatProperties);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult vkGetPhysicalDeviceImageFormatProperties2(VkPhysicalDevice physicalDevice, VkPhysicalDeviceImageFormatInfo2* pImageFormatInfo, VkImageFormatProperties2* pImageFormatProperties)
    {
        return _vkGetPhysicalDeviceImageFormatProperties2(physicalDevice, pImageFormatInfo, pImageFormatProperties);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void vkGetPhysicalDeviceQueueFamilyProperties2(VkPhysicalDevice physicalDevice, uint* pQueueFamilyPropertyCount, VkQueueFamilyProperties2* pQueueFamilyProperties)
    {
        _vkGetPhysicalDeviceQueueFamilyProperties2(physicalDevice, pQueueFamilyPropertyCount, pQueueFamilyProperties);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void vkGetPhysicalDeviceMemoryProperties2(VkPhysicalDevice physicalDevice, VkPhysicalDeviceMemoryProperties2* pMemoryProperties)
    {
        _vkGetPhysicalDeviceMemoryProperties2(physicalDevice, pMemoryProperties);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void vkGetPhysicalDeviceSparseImageFormatProperties2(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSparseImageFormatInfo2* pFormatInfo, uint* pPropertyCount, VkSparseImageFormatProperties2* pProperties)
    {
        _vkGetPhysicalDeviceSparseImageFormatProperties2(physicalDevice, pFormatInfo, pPropertyCount, pProperties);
    }
}