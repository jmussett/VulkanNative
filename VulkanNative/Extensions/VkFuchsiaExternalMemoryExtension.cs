namespace VulkanNative;

public unsafe class VkFuchsiaExternalMemoryExtension
{
    public delegate* unmanaged[Cdecl]<VkDevice, VkMemoryGetZirconHandleInfoFUCHSIA*, nint*, VkResult> vkGetMemoryZirconHandleFUCHSIA;
    public delegate* unmanaged[Cdecl]<VkDevice, VkExternalMemoryHandleTypeFlags, nint, VkMemoryZirconHandlePropertiesFUCHSIA*, VkResult> vkGetMemoryZirconHandlePropertiesFUCHSIA;
}