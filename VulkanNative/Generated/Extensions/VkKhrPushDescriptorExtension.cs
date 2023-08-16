using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkKhrPushDescriptorExtension
{
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPipelineBindPoint, VkPipelineLayout, uint, uint, VkWriteDescriptorSet*, void> _vkCmdPushDescriptorSetKHR;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDescriptorUpdateTemplate, VkPipelineLayout, uint, void*, void> _vkCmdPushDescriptorSetWithTemplateKHR;

    public VkKhrPushDescriptorExtension(VkDevice device, IFunctionLoader loader)
    {
        _vkCmdPushDescriptorSetKHR = (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPipelineBindPoint, VkPipelineLayout, uint, uint, VkWriteDescriptorSet*, void>)loader.GetDeviceProcAddr(device, "vkCmdPushDescriptorSetKHR");
        _vkCmdPushDescriptorSetWithTemplateKHR = (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDescriptorUpdateTemplate, VkPipelineLayout, uint, void*, void>)loader.GetDeviceProcAddr(device, "vkCmdPushDescriptorSetWithTemplateKHR");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdPushDescriptorSetKHR(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint set, uint descriptorWriteCount, VkWriteDescriptorSet* pDescriptorWrites)
    {
        _vkCmdPushDescriptorSetKHR(commandBuffer, pipelineBindPoint, layout, set, descriptorWriteCount, pDescriptorWrites);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdPushDescriptorSetWithTemplateKHR(VkCommandBuffer commandBuffer, VkDescriptorUpdateTemplate descriptorUpdateTemplate, VkPipelineLayout layout, uint set, void* pData)
    {
        _vkCmdPushDescriptorSetWithTemplateKHR(commandBuffer, descriptorUpdateTemplate, layout, set, pData);
    }
}