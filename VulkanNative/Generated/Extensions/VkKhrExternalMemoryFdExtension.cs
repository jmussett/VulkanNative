using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkKhrExternalMemoryFdExtension
{
    private delegate* unmanaged[Cdecl]<VkDevice, VkMemoryGetFdInfoKHR*, nint*, VkResult> _vkGetMemoryFdKHR;
    private delegate* unmanaged[Cdecl]<VkDevice, VkExternalMemoryHandleTypeFlags, nint, VkMemoryFdPropertiesKHR*, VkResult> _vkGetMemoryFdPropertiesKHR;

    public VkKhrExternalMemoryFdExtension(VkDevice device, IVulkanLoader loader)
    {
        _vkGetMemoryFdKHR = (delegate* unmanaged[Cdecl]<VkDevice, VkMemoryGetFdInfoKHR*, nint*, VkResult>)loader.GetDeviceProcAddr(device, "vkGetMemoryFdKHR");
        _vkGetMemoryFdPropertiesKHR = (delegate* unmanaged[Cdecl]<VkDevice, VkExternalMemoryHandleTypeFlags, nint, VkMemoryFdPropertiesKHR*, VkResult>)loader.GetDeviceProcAddr(device, "vkGetMemoryFdPropertiesKHR");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkGetMemoryFdKHR(VkDevice device, VkMemoryGetFdInfoKHR* pGetFdInfo, nint* pFd)
    {
        return _vkGetMemoryFdKHR(device, pGetFdInfo, pFd);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkGetMemoryFdPropertiesKHR(VkDevice device, VkExternalMemoryHandleTypeFlags handleType, nint fd, VkMemoryFdPropertiesKHR* pMemoryFdProperties)
    {
        return _vkGetMemoryFdPropertiesKHR(device, handleType, fd, pMemoryFdProperties);
    }
}