namespace VulkanNative;

public unsafe class VkKhrExternalFenceWin32Extension
{
    public delegate* unmanaged[Cdecl]<VkDevice, VkImportFenceWin32HandleInfoKHR*, VkResult> vkImportFenceWin32HandleKHR;
    public delegate* unmanaged[Cdecl]<VkDevice, VkFenceGetWin32HandleInfoKHR*, nint*, VkResult> vkGetFenceWin32HandleKHR;
}