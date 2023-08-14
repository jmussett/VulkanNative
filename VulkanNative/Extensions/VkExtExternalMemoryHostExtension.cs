namespace VulkanNative;

public unsafe class VkExtExternalMemoryHostExtension
{
    public delegate* unmanaged[Cdecl]<VkDevice, VkExternalMemoryHandleTypeFlags, void*, VkMemoryHostPointerPropertiesEXT*, VkResult> vkGetMemoryHostPointerPropertiesEXT;
}