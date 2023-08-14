namespace VulkanNative;

public unsafe class VkNvDeviceGeneratedCommandsExtension
{
    public delegate* unmanaged[Cdecl]<VkDevice, VkGeneratedCommandsMemoryRequirementsInfoNV*, VkMemoryRequirements2*, void> vkGetGeneratedCommandsMemoryRequirementsNV;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkGeneratedCommandsInfoNV*, void> vkCmdPreprocessGeneratedCommandsNV;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBool32, VkGeneratedCommandsInfoNV*, void> vkCmdExecuteGeneratedCommandsNV;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPipelineBindPoint, VkPipeline, uint, void> vkCmdBindPipelineShaderGroupNV;
    public delegate* unmanaged[Cdecl]<VkDevice, VkIndirectCommandsLayoutCreateInfoNV*, VkAllocationCallbacks*, VkIndirectCommandsLayoutNV*, VkResult> vkCreateIndirectCommandsLayoutNV;
    public delegate* unmanaged[Cdecl]<VkDevice, VkIndirectCommandsLayoutNV, VkAllocationCallbacks*, void> vkDestroyIndirectCommandsLayoutNV;
}