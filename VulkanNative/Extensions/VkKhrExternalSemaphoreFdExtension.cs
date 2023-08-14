namespace VulkanNative;

public unsafe class VkKhrExternalSemaphoreFdExtension
{
    public delegate* unmanaged[Cdecl]<VkDevice, VkImportSemaphoreFdInfoKHR*, VkResult> vkImportSemaphoreFdKHR;
    public delegate* unmanaged[Cdecl]<VkDevice, VkSemaphoreGetFdInfoKHR*, nint*, VkResult> vkGetSemaphoreFdKHR;
}