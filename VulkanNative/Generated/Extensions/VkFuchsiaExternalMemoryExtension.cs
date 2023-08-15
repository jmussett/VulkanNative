using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkFuchsiaExternalMemoryExtension
{
    private delegate* unmanaged[Cdecl]<VkDevice, VkMemoryGetZirconHandleInfoFUCHSIA*, nint*, VkResult> _vkGetMemoryZirconHandleFUCHSIA;
    private delegate* unmanaged[Cdecl]<VkDevice, VkExternalMemoryHandleTypeFlags, nint, VkMemoryZirconHandlePropertiesFUCHSIA*, VkResult> _vkGetMemoryZirconHandlePropertiesFUCHSIA;

    public VkFuchsiaExternalMemoryExtension(VkDevice device, IVulkanLoader loader)
    {
        _vkGetMemoryZirconHandleFUCHSIA = (delegate* unmanaged[Cdecl]<VkDevice, VkMemoryGetZirconHandleInfoFUCHSIA*, nint*, VkResult>)loader.GetDeviceProcAddr(device, "vkGetMemoryZirconHandleFUCHSIA");
        _vkGetMemoryZirconHandlePropertiesFUCHSIA = (delegate* unmanaged[Cdecl]<VkDevice, VkExternalMemoryHandleTypeFlags, nint, VkMemoryZirconHandlePropertiesFUCHSIA*, VkResult>)loader.GetDeviceProcAddr(device, "vkGetMemoryZirconHandlePropertiesFUCHSIA");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkGetMemoryZirconHandleFUCHSIA(VkDevice device, VkMemoryGetZirconHandleInfoFUCHSIA* pGetZirconHandleInfo, nint* pZirconHandle)
    {
        return _vkGetMemoryZirconHandleFUCHSIA(device, pGetZirconHandleInfo, pZirconHandle);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkGetMemoryZirconHandlePropertiesFUCHSIA(VkDevice device, VkExternalMemoryHandleTypeFlags handleType, nint zirconHandle, VkMemoryZirconHandlePropertiesFUCHSIA* pMemoryZirconHandleProperties)
    {
        return _vkGetMemoryZirconHandlePropertiesFUCHSIA(device, handleType, zirconHandle, pMemoryZirconHandleProperties);
    }
}