namespace VulkanNative;

public unsafe class VkExtShaderModuleIdentifierExtension
{
    public delegate* unmanaged[Cdecl]<VkDevice, VkShaderModule, VkShaderModuleIdentifierEXT*, void> vkGetShaderModuleIdentifierEXT;
    public delegate* unmanaged[Cdecl]<VkDevice, VkShaderModuleCreateInfo*, VkShaderModuleIdentifierEXT*, void> vkGetShaderModuleCreateInfoIdentifierEXT;
}