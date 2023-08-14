using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkKhrExternalSemaphoreFdExtension
{
    private delegate* unmanaged[Cdecl]<VkDevice, VkImportSemaphoreFdInfoKHR*, VkResult> _vkImportSemaphoreFdKHR;
    private delegate* unmanaged[Cdecl]<VkDevice, VkSemaphoreGetFdInfoKHR*, nint*, VkResult> _vkGetSemaphoreFdKHR;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkImportSemaphoreFdKHR(VkDevice device, VkImportSemaphoreFdInfoKHR* pImportSemaphoreFdInfo)
    {
        return _vkImportSemaphoreFdKHR(device, pImportSemaphoreFdInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkGetSemaphoreFdKHR(VkDevice device, VkSemaphoreGetFdInfoKHR* pGetFdInfo, nint* pFd)
    {
        return _vkGetSemaphoreFdKHR(device, pGetFdInfo, pFd);
    }
}