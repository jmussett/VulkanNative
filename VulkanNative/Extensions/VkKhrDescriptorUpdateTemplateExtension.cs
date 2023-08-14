using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkKhrDescriptorUpdateTemplateExtension
{
    private delegate* unmanaged[Cdecl]<VkDevice, VkDescriptorUpdateTemplateCreateInfo*, VkAllocationCallbacks*, VkDescriptorUpdateTemplate*, VkResult> _vkCreateDescriptorUpdateTemplate;
    private delegate* unmanaged[Cdecl]<VkDevice, VkDescriptorUpdateTemplate, VkAllocationCallbacks*, void> _vkDestroyDescriptorUpdateTemplate;
    private delegate* unmanaged[Cdecl]<VkDevice, VkDescriptorSet, VkDescriptorUpdateTemplate, void*, void> _vkUpdateDescriptorSetWithTemplate;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDescriptorUpdateTemplate, VkPipelineLayout, uint, void*, void> _vkCmdPushDescriptorSetWithTemplateKHR;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkCreateDescriptorUpdateTemplate(VkDevice device, VkDescriptorUpdateTemplateCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDescriptorUpdateTemplate* pDescriptorUpdateTemplate)
    {
        return _vkCreateDescriptorUpdateTemplate(device, pCreateInfo, pAllocator, pDescriptorUpdateTemplate);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkDestroyDescriptorUpdateTemplate(VkDevice device, VkDescriptorUpdateTemplate descriptorUpdateTemplate, VkAllocationCallbacks* pAllocator)
    {
        _vkDestroyDescriptorUpdateTemplate(device, descriptorUpdateTemplate, pAllocator);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkUpdateDescriptorSetWithTemplate(VkDevice device, VkDescriptorSet descriptorSet, VkDescriptorUpdateTemplate descriptorUpdateTemplate, void* pData)
    {
        _vkUpdateDescriptorSetWithTemplate(device, descriptorSet, descriptorUpdateTemplate, pData);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdPushDescriptorSetWithTemplateKHR(VkCommandBuffer commandBuffer, VkDescriptorUpdateTemplate descriptorUpdateTemplate, VkPipelineLayout layout, uint set, void* pData)
    {
        _vkCmdPushDescriptorSetWithTemplateKHR(commandBuffer, descriptorUpdateTemplate, layout, set, pData);
    }
}