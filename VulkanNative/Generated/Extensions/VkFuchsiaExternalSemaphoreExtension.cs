using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkFuchsiaExternalSemaphoreExtension
{
    private delegate* unmanaged[Cdecl]<VkDevice, VkImportSemaphoreZirconHandleInfoFUCHSIA*, VkResult> _vkImportSemaphoreZirconHandleFUCHSIA;
    private delegate* unmanaged[Cdecl]<VkDevice, VkSemaphoreGetZirconHandleInfoFUCHSIA*, nint*, VkResult> _vkGetSemaphoreZirconHandleFUCHSIA;

    public VkFuchsiaExternalSemaphoreExtension(VkDevice device, IFunctionLoader loader)
    {
        _vkImportSemaphoreZirconHandleFUCHSIA = (delegate* unmanaged[Cdecl]<VkDevice, VkImportSemaphoreZirconHandleInfoFUCHSIA*, VkResult>)loader.GetDeviceProcAddr(device, "vkImportSemaphoreZirconHandleFUCHSIA");
        _vkGetSemaphoreZirconHandleFUCHSIA = (delegate* unmanaged[Cdecl]<VkDevice, VkSemaphoreGetZirconHandleInfoFUCHSIA*, nint*, VkResult>)loader.GetDeviceProcAddr(device, "vkGetSemaphoreZirconHandleFUCHSIA");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult vkImportSemaphoreZirconHandleFUCHSIA(VkDevice device, VkImportSemaphoreZirconHandleInfoFUCHSIA* pImportSemaphoreZirconHandleInfo)
    {
        return _vkImportSemaphoreZirconHandleFUCHSIA(device, pImportSemaphoreZirconHandleInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult vkGetSemaphoreZirconHandleFUCHSIA(VkDevice device, VkSemaphoreGetZirconHandleInfoFUCHSIA* pGetZirconHandleInfo, nint* pZirconHandle)
    {
        return _vkGetSemaphoreZirconHandleFUCHSIA(device, pGetZirconHandleInfo, pZirconHandle);
    }
}