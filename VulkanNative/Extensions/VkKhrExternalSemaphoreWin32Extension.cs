using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkKhrExternalSemaphoreWin32Extension
{
    private delegate* unmanaged[Cdecl]<VkDevice, VkImportSemaphoreWin32HandleInfoKHR*, VkResult> _vkImportSemaphoreWin32HandleKHR;
    private delegate* unmanaged[Cdecl]<VkDevice, VkSemaphoreGetWin32HandleInfoKHR*, nint*, VkResult> _vkGetSemaphoreWin32HandleKHR;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkImportSemaphoreWin32HandleKHR(VkDevice device, VkImportSemaphoreWin32HandleInfoKHR* pImportSemaphoreWin32HandleInfo)
    {
        return _vkImportSemaphoreWin32HandleKHR(device, pImportSemaphoreWin32HandleInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkGetSemaphoreWin32HandleKHR(VkDevice device, VkSemaphoreGetWin32HandleInfoKHR* pGetWin32HandleInfo, nint* pHandle)
    {
        return _vkGetSemaphoreWin32HandleKHR(device, pGetWin32HandleInfo, pHandle);
    }
}