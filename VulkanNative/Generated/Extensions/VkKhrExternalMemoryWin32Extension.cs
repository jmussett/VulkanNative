using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkKhrExternalMemoryWin32Extension
{
    private delegate* unmanaged[Cdecl]<VkDevice, VkMemoryGetWin32HandleInfoKHR*, nint*, VkResult> _vkGetMemoryWin32HandleKHR;
    private delegate* unmanaged[Cdecl]<VkDevice, VkExternalMemoryHandleTypeFlags, nint, VkMemoryWin32HandlePropertiesKHR*, VkResult> _vkGetMemoryWin32HandlePropertiesKHR;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkGetMemoryWin32HandleKHR(VkDevice device, VkMemoryGetWin32HandleInfoKHR* pGetWin32HandleInfo, nint* pHandle)
    {
        return _vkGetMemoryWin32HandleKHR(device, pGetWin32HandleInfo, pHandle);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkGetMemoryWin32HandlePropertiesKHR(VkDevice device, VkExternalMemoryHandleTypeFlags handleType, nint handle, VkMemoryWin32HandlePropertiesKHR* pMemoryWin32HandleProperties)
    {
        return _vkGetMemoryWin32HandlePropertiesKHR(device, handleType, handle, pMemoryWin32HandleProperties);
    }
}