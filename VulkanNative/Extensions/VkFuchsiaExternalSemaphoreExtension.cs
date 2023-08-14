using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkFuchsiaExternalSemaphoreExtension
{
    private delegate* unmanaged[Cdecl]<VkDevice, VkImportSemaphoreZirconHandleInfoFUCHSIA*, VkResult> _vkImportSemaphoreZirconHandleFUCHSIA;
    private delegate* unmanaged[Cdecl]<VkDevice, VkSemaphoreGetZirconHandleInfoFUCHSIA*, nint*, VkResult> _vkGetSemaphoreZirconHandleFUCHSIA;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkImportSemaphoreZirconHandleFUCHSIA(VkDevice device, VkImportSemaphoreZirconHandleInfoFUCHSIA* pImportSemaphoreZirconHandleInfo)
    {
        return _vkImportSemaphoreZirconHandleFUCHSIA(device, pImportSemaphoreZirconHandleInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkGetSemaphoreZirconHandleFUCHSIA(VkDevice device, VkSemaphoreGetZirconHandleInfoFUCHSIA* pGetZirconHandleInfo, nint* pZirconHandle)
    {
        return _vkGetSemaphoreZirconHandleFUCHSIA(device, pGetZirconHandleInfo, pZirconHandle);
    }
}