namespace VulkanNative;

public unsafe class VkExtAttachmentFeedbackLoopDynamicStateExtension
{
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkImageAspectFlags, void> vkCmdSetAttachmentFeedbackLoopEnableEXT;
}