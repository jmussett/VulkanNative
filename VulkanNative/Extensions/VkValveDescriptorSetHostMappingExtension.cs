namespace VulkanNative;

public unsafe class VkValveDescriptorSetHostMappingExtension
{
    public delegate* unmanaged[Cdecl]<VkDevice, VkDescriptorSetBindingReferenceVALVE*, VkDescriptorSetLayoutHostMappingInfoVALVE*, void> vkGetDescriptorSetLayoutHostMappingInfoVALVE;
    public delegate* unmanaged[Cdecl]<VkDevice, VkDescriptorSet, void**, void> vkGetDescriptorSetHostMappingVALVE;
}