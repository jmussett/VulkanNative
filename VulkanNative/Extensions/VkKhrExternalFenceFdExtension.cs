namespace VulkanNative;

public unsafe class VkKhrExternalFenceFdExtension
{
    public delegate* unmanaged[Cdecl]<VkDevice, VkImportFenceFdInfoKHR*, VkResult> vkImportFenceFdKHR;
    public delegate* unmanaged[Cdecl]<VkDevice, VkFenceGetFdInfoKHR*, nint*, VkResult> vkGetFenceFdKHR;
}