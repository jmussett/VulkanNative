namespace VulkanNative;

public unsafe class VkKhrPushDescriptorExtension
{
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPipelineBindPoint, VkPipelineLayout, uint, uint, VkWriteDescriptorSet*, void> vkCmdPushDescriptorSetKHR;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDescriptorUpdateTemplate, VkPipelineLayout, uint, void*, void> vkCmdPushDescriptorSetWithTemplateKHR;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDescriptorUpdateTemplate, VkPipelineLayout, uint, void*, void> vkCmdPushDescriptorSetWithTemplateKHR;
}