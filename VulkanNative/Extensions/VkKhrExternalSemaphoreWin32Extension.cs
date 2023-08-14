namespace VulkanNative;

public unsafe class VkKhrExternalSemaphoreWin32Extension
{
    public delegate* unmanaged[Cdecl]<VkDevice, VkImportSemaphoreWin32HandleInfoKHR*, VkResult> vkImportSemaphoreWin32HandleKHR;
    public delegate* unmanaged[Cdecl]<VkDevice, VkSemaphoreGetWin32HandleInfoKHR*, nint*, VkResult> vkGetSemaphoreWin32HandleKHR;
}