namespace VulkanNative;

public unsafe class VkKhrExternalMemoryWin32Extension
{
    public delegate* unmanaged[Cdecl]<VkDevice, VkMemoryGetWin32HandleInfoKHR*, nint*, VkResult> vkGetMemoryWin32HandleKHR;
    public delegate* unmanaged[Cdecl]<VkDevice, VkExternalMemoryHandleTypeFlags, nint, VkMemoryWin32HandlePropertiesKHR*, VkResult> vkGetMemoryWin32HandlePropertiesKHR;
}