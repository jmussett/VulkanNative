namespace VulkanNative;

public unsafe class VkKhrDescriptorUpdateTemplateExtension
{
    public delegate* unmanaged[Cdecl]<VkDevice, VkDescriptorUpdateTemplateCreateInfo*, VkAllocationCallbacks*, VkDescriptorUpdateTemplate*, VkResult> vkCreateDescriptorUpdateTemplate;
    public delegate* unmanaged[Cdecl]<VkDevice, VkDescriptorUpdateTemplate, VkAllocationCallbacks*, void> vkDestroyDescriptorUpdateTemplate;
    public delegate* unmanaged[Cdecl]<VkDevice, VkDescriptorSet, VkDescriptorUpdateTemplate, void*, void> vkUpdateDescriptorSetWithTemplate;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDescriptorUpdateTemplate, VkPipelineLayout, uint, void*, void> vkCmdPushDescriptorSetWithTemplateKHR;
}