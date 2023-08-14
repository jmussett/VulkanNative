namespace VulkanNative;

public unsafe class VkKhrSamplerYcbcrConversionExtension
{
    public delegate* unmanaged[Cdecl]<VkDevice, VkSamplerYcbcrConversionCreateInfo*, VkAllocationCallbacks*, VkSamplerYcbcrConversion*, VkResult> vkCreateSamplerYcbcrConversion;
    public delegate* unmanaged[Cdecl]<VkDevice, VkSamplerYcbcrConversion, VkAllocationCallbacks*, void> vkDestroySamplerYcbcrConversion;
}