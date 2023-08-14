namespace VulkanNative;

public unsafe class VkNvDeviceGeneratedCommandsComputeExtension
{
    public delegate* unmanaged[Cdecl]<VkDevice, VkComputePipelineCreateInfo*, VkMemoryRequirements2*, void> vkGetPipelineIndirectMemoryRequirementsNV;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPipelineBindPoint, VkPipeline, void> vkCmdUpdatePipelineIndirectBufferNV;
    public delegate* unmanaged[Cdecl]<VkDevice, VkPipelineIndirectDeviceAddressInfoNV*, VkDeviceAddress> vkGetPipelineIndirectDeviceAddressNV;
}