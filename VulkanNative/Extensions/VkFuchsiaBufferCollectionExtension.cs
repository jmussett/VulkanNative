using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkFuchsiaBufferCollectionExtension
{
    private delegate* unmanaged[Cdecl]<VkDevice, VkBufferCollectionCreateInfoFUCHSIA*, VkAllocationCallbacks*, VkBufferCollectionFUCHSIA*, VkResult> _vkCreateBufferCollectionFUCHSIA;
    private delegate* unmanaged[Cdecl]<VkDevice, VkBufferCollectionFUCHSIA, VkImageConstraintsInfoFUCHSIA*, VkResult> _vkSetBufferCollectionImageConstraintsFUCHSIA;
    private delegate* unmanaged[Cdecl]<VkDevice, VkBufferCollectionFUCHSIA, VkBufferConstraintsInfoFUCHSIA*, VkResult> _vkSetBufferCollectionBufferConstraintsFUCHSIA;
    private delegate* unmanaged[Cdecl]<VkDevice, VkBufferCollectionFUCHSIA, VkAllocationCallbacks*, void> _vkDestroyBufferCollectionFUCHSIA;
    private delegate* unmanaged[Cdecl]<VkDevice, VkBufferCollectionFUCHSIA, VkBufferCollectionPropertiesFUCHSIA*, VkResult> _vkGetBufferCollectionPropertiesFUCHSIA;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkCreateBufferCollectionFUCHSIA(VkDevice device, VkBufferCollectionCreateInfoFUCHSIA* pCreateInfo, VkAllocationCallbacks* pAllocator, VkBufferCollectionFUCHSIA* pCollection)
    {
        return _vkCreateBufferCollectionFUCHSIA(device, pCreateInfo, pAllocator, pCollection);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkSetBufferCollectionImageConstraintsFUCHSIA(VkDevice device, VkBufferCollectionFUCHSIA collection, VkImageConstraintsInfoFUCHSIA* pImageConstraintsInfo)
    {
        return _vkSetBufferCollectionImageConstraintsFUCHSIA(device, collection, pImageConstraintsInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkSetBufferCollectionBufferConstraintsFUCHSIA(VkDevice device, VkBufferCollectionFUCHSIA collection, VkBufferConstraintsInfoFUCHSIA* pBufferConstraintsInfo)
    {
        return _vkSetBufferCollectionBufferConstraintsFUCHSIA(device, collection, pBufferConstraintsInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkDestroyBufferCollectionFUCHSIA(VkDevice device, VkBufferCollectionFUCHSIA collection, VkAllocationCallbacks* pAllocator)
    {
        _vkDestroyBufferCollectionFUCHSIA(device, collection, pAllocator);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkGetBufferCollectionPropertiesFUCHSIA(VkDevice device, VkBufferCollectionFUCHSIA collection, VkBufferCollectionPropertiesFUCHSIA* pProperties)
    {
        return _vkGetBufferCollectionPropertiesFUCHSIA(device, collection, pProperties);
    }
}