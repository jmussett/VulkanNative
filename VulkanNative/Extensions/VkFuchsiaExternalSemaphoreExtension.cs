namespace VulkanNative;

public unsafe class VkFuchsiaExternalSemaphoreExtension
{
    public delegate* unmanaged[Cdecl]<VkDevice, VkImportSemaphoreZirconHandleInfoFUCHSIA*, VkResult> vkImportSemaphoreZirconHandleFUCHSIA;
    public delegate* unmanaged[Cdecl]<VkDevice, VkSemaphoreGetZirconHandleInfoFUCHSIA*, nint*, VkResult> vkGetSemaphoreZirconHandleFUCHSIA;
}