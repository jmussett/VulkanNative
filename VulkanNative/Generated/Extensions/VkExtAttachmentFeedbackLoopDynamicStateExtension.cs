using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkExtAttachmentFeedbackLoopDynamicStateExtension
{
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkImageAspectFlags, void> _vkCmdSetAttachmentFeedbackLoopEnableEXT;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdSetAttachmentFeedbackLoopEnableEXT(VkCommandBuffer commandBuffer, VkImageAspectFlags aspectMask)
    {
        _vkCmdSetAttachmentFeedbackLoopEnableEXT(commandBuffer, aspectMask);
    }
}