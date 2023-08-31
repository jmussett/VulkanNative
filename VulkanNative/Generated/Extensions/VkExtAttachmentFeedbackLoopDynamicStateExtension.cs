using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkExtAttachmentFeedbackLoopDynamicStateExtension
{
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkImageAspectFlags, void> _vkCmdSetAttachmentFeedbackLoopEnableEXT;

    public VkExtAttachmentFeedbackLoopDynamicStateExtension(VkDevice device, IFunctionLoader loader)
    {
        _vkCmdSetAttachmentFeedbackLoopEnableEXT = (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkImageAspectFlags, void>)loader.GetDeviceProcAddr(device, "vkCmdSetAttachmentFeedbackLoopEnableEXT");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void vkCmdSetAttachmentFeedbackLoopEnableEXT(VkCommandBuffer commandBuffer, VkImageAspectFlags aspectMask)
    {
        _vkCmdSetAttachmentFeedbackLoopEnableEXT(commandBuffer, aspectMask);
    }
}