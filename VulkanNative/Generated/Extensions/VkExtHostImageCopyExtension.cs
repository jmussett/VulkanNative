using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkExtHostImageCopyExtension
{
    private delegate* unmanaged[Cdecl]<VkDevice, VkCopyMemoryToImageInfoEXT*, VkResult> _vkCopyMemoryToImageEXT;
    private delegate* unmanaged[Cdecl]<VkDevice, VkCopyImageToMemoryInfoEXT*, VkResult> _vkCopyImageToMemoryEXT;
    private delegate* unmanaged[Cdecl]<VkDevice, VkCopyImageToImageInfoEXT*, VkResult> _vkCopyImageToImageEXT;
    private delegate* unmanaged[Cdecl]<VkDevice, uint, VkHostImageLayoutTransitionInfoEXT*, VkResult> _vkTransitionImageLayoutEXT;
    private delegate* unmanaged[Cdecl]<VkDevice, VkImage, VkImageSubresource2KHR*, VkSubresourceLayout2KHR*, void> _vkGetImageSubresourceLayout2KHR;

    public VkExtHostImageCopyExtension(VkDevice device, IVulkanLoader loader)
    {
        _vkCopyMemoryToImageEXT = (delegate* unmanaged[Cdecl]<VkDevice, VkCopyMemoryToImageInfoEXT*, VkResult>)loader.GetDeviceProcAddr(device, "vkCopyMemoryToImageEXT");
        _vkCopyImageToMemoryEXT = (delegate* unmanaged[Cdecl]<VkDevice, VkCopyImageToMemoryInfoEXT*, VkResult>)loader.GetDeviceProcAddr(device, "vkCopyImageToMemoryEXT");
        _vkCopyImageToImageEXT = (delegate* unmanaged[Cdecl]<VkDevice, VkCopyImageToImageInfoEXT*, VkResult>)loader.GetDeviceProcAddr(device, "vkCopyImageToImageEXT");
        _vkTransitionImageLayoutEXT = (delegate* unmanaged[Cdecl]<VkDevice, uint, VkHostImageLayoutTransitionInfoEXT*, VkResult>)loader.GetDeviceProcAddr(device, "vkTransitionImageLayoutEXT");
        _vkGetImageSubresourceLayout2KHR = (delegate* unmanaged[Cdecl]<VkDevice, VkImage, VkImageSubresource2KHR*, VkSubresourceLayout2KHR*, void>)loader.GetDeviceProcAddr(device, "vkGetImageSubresourceLayout2KHR");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkCopyMemoryToImageEXT(VkDevice device, VkCopyMemoryToImageInfoEXT* pCopyMemoryToImageInfo)
    {
        return _vkCopyMemoryToImageEXT(device, pCopyMemoryToImageInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkCopyImageToMemoryEXT(VkDevice device, VkCopyImageToMemoryInfoEXT* pCopyImageToMemoryInfo)
    {
        return _vkCopyImageToMemoryEXT(device, pCopyImageToMemoryInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkCopyImageToImageEXT(VkDevice device, VkCopyImageToImageInfoEXT* pCopyImageToImageInfo)
    {
        return _vkCopyImageToImageEXT(device, pCopyImageToImageInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkTransitionImageLayoutEXT(VkDevice device, uint transitionCount, VkHostImageLayoutTransitionInfoEXT* pTransitions)
    {
        return _vkTransitionImageLayoutEXT(device, transitionCount, pTransitions);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkGetImageSubresourceLayout2KHR(VkDevice device, VkImage image, VkImageSubresource2KHR* pSubresource, VkSubresourceLayout2KHR* pLayout)
    {
        _vkGetImageSubresourceLayout2KHR(device, image, pSubresource, pLayout);
    }
}