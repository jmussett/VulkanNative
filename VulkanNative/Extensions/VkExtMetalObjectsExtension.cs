namespace VulkanNative;

public unsafe class VkExtMetalObjectsExtension
{
    public delegate* unmanaged[Cdecl]<VkDevice, VkExportMetalObjectsInfoEXT*, void> vkExportMetalObjectsEXT;
}