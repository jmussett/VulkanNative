namespace VulkanNative;

public unsafe class VkKhrExternalMemoryFdExtension
{
    public delegate* unmanaged[Cdecl]<VkDevice, VkMemoryGetFdInfoKHR*, nint*, VkResult> vkGetMemoryFdKHR;
    public delegate* unmanaged[Cdecl]<VkDevice, VkExternalMemoryHandleTypeFlags, nint, VkMemoryFdPropertiesKHR*, VkResult> vkGetMemoryFdPropertiesKHR;
}