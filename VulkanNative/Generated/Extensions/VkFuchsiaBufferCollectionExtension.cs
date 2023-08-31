using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkFuchsiaBufferCollectionExtension
{
    private delegate* unmanaged[Cdecl]<VkDevice, VkBufferCollectionCreateInfoFUCHSIA*, VkAllocationCallbacks*, VkBufferCollectionFUCHSIA*, VkResult> _vkCreateBufferCollectionFUCHSIA;
    private delegate* unmanaged[Cdecl]<VkDevice, VkBufferCollectionFUCHSIA, VkImageConstraintsInfoFUCHSIA*, VkResult> _vkSetBufferCollectionImageConstraintsFUCHSIA;
    private delegate* unmanaged[Cdecl]<VkDevice, VkBufferCollectionFUCHSIA, VkBufferConstraintsInfoFUCHSIA*, VkResult> _vkSetBufferCollectionBufferConstraintsFUCHSIA;
    private delegate* unmanaged[Cdecl]<VkDevice, VkBufferCollectionFUCHSIA, VkAllocationCallbacks*, void> _vkDestroyBufferCollectionFUCHSIA;
    private delegate* unmanaged[Cdecl]<VkDevice, VkBufferCollectionFUCHSIA, VkBufferCollectionPropertiesFUCHSIA*, VkResult> _vkGetBufferCollectionPropertiesFUCHSIA;

    public VkFuchsiaBufferCollectionExtension(VkDevice device, IFunctionLoader loader)
    {
        _vkCreateBufferCollectionFUCHSIA = (delegate* unmanaged[Cdecl]<VkDevice, VkBufferCollectionCreateInfoFUCHSIA*, VkAllocationCallbacks*, VkBufferCollectionFUCHSIA*, VkResult>)loader.GetDeviceProcAddr(device, "vkCreateBufferCollectionFUCHSIA");
        _vkSetBufferCollectionImageConstraintsFUCHSIA = (delegate* unmanaged[Cdecl]<VkDevice, VkBufferCollectionFUCHSIA, VkImageConstraintsInfoFUCHSIA*, VkResult>)loader.GetDeviceProcAddr(device, "vkSetBufferCollectionImageConstraintsFUCHSIA");
        _vkSetBufferCollectionBufferConstraintsFUCHSIA = (delegate* unmanaged[Cdecl]<VkDevice, VkBufferCollectionFUCHSIA, VkBufferConstraintsInfoFUCHSIA*, VkResult>)loader.GetDeviceProcAddr(device, "vkSetBufferCollectionBufferConstraintsFUCHSIA");
        _vkDestroyBufferCollectionFUCHSIA = (delegate* unmanaged[Cdecl]<VkDevice, VkBufferCollectionFUCHSIA, VkAllocationCallbacks*, void>)loader.GetDeviceProcAddr(device, "vkDestroyBufferCollectionFUCHSIA");
        _vkGetBufferCollectionPropertiesFUCHSIA = (delegate* unmanaged[Cdecl]<VkDevice, VkBufferCollectionFUCHSIA, VkBufferCollectionPropertiesFUCHSIA*, VkResult>)loader.GetDeviceProcAddr(device, "vkGetBufferCollectionPropertiesFUCHSIA");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult vkCreateBufferCollectionFUCHSIA(VkDevice device, VkBufferCollectionCreateInfoFUCHSIA* pCreateInfo, VkAllocationCallbacks* pAllocator, VkBufferCollectionFUCHSIA* pCollection)
    {
        return _vkCreateBufferCollectionFUCHSIA(device, pCreateInfo, pAllocator, pCollection);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult vkSetBufferCollectionImageConstraintsFUCHSIA(VkDevice device, VkBufferCollectionFUCHSIA collection, VkImageConstraintsInfoFUCHSIA* pImageConstraintsInfo)
    {
        return _vkSetBufferCollectionImageConstraintsFUCHSIA(device, collection, pImageConstraintsInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult vkSetBufferCollectionBufferConstraintsFUCHSIA(VkDevice device, VkBufferCollectionFUCHSIA collection, VkBufferConstraintsInfoFUCHSIA* pBufferConstraintsInfo)
    {
        return _vkSetBufferCollectionBufferConstraintsFUCHSIA(device, collection, pBufferConstraintsInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void vkDestroyBufferCollectionFUCHSIA(VkDevice device, VkBufferCollectionFUCHSIA collection, VkAllocationCallbacks* pAllocator)
    {
        _vkDestroyBufferCollectionFUCHSIA(device, collection, pAllocator);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult vkGetBufferCollectionPropertiesFUCHSIA(VkDevice device, VkBufferCollectionFUCHSIA collection, VkBufferCollectionPropertiesFUCHSIA* pProperties)
    {
        return _vkGetBufferCollectionPropertiesFUCHSIA(device, collection, pProperties);
    }
}