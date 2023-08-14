using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkFuchsiaExternalMemoryExtension
{
    private delegate* unmanaged[Cdecl]<VkDevice, VkMemoryGetZirconHandleInfoFUCHSIA*, nint*, VkResult> _vkGetMemoryZirconHandleFUCHSIA;
    private delegate* unmanaged[Cdecl]<VkDevice, VkExternalMemoryHandleTypeFlags, nint, VkMemoryZirconHandlePropertiesFUCHSIA*, VkResult> _vkGetMemoryZirconHandlePropertiesFUCHSIA;

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