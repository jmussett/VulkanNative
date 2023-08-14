namespace VulkanNative;

public unsafe class VkExtDeviceFaultExtension
{
    public delegate* unmanaged[Cdecl]<VkDevice, VkDeviceFaultCountsEXT*, VkDeviceFaultInfoEXT*, VkResult> vkGetDeviceFaultInfoEXT;
}