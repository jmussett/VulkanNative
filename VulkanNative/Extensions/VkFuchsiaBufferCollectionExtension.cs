namespace VulkanNative;

public unsafe class VkFuchsiaBufferCollectionExtension
{
    public delegate* unmanaged[Cdecl]<VkDevice, VkBufferCollectionCreateInfoFUCHSIA*, VkAllocationCallbacks*, VkBufferCollectionFUCHSIA*, VkResult> vkCreateBufferCollectionFUCHSIA;
    public delegate* unmanaged[Cdecl]<VkDevice, VkBufferCollectionFUCHSIA, VkImageConstraintsInfoFUCHSIA*, VkResult> vkSetBufferCollectionImageConstraintsFUCHSIA;
    public delegate* unmanaged[Cdecl]<VkDevice, VkBufferCollectionFUCHSIA, VkBufferConstraintsInfoFUCHSIA*, VkResult> vkSetBufferCollectionBufferConstraintsFUCHSIA;
    public delegate* unmanaged[Cdecl]<VkDevice, VkBufferCollectionFUCHSIA, VkAllocationCallbacks*, void> vkDestroyBufferCollectionFUCHSIA;
    public delegate* unmanaged[Cdecl]<VkDevice, VkBufferCollectionFUCHSIA, VkBufferCollectionPropertiesFUCHSIA*, VkResult> vkGetBufferCollectionPropertiesFUCHSIA;
}