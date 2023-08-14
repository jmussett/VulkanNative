namespace VulkanNative;

public unsafe class VkKhrCreateRenderpass2Extension
{
    public delegate* unmanaged[Cdecl]<VkDevice, VkRenderPassCreateInfo2*, VkAllocationCallbacks*, VkRenderPass*, VkResult> vkCreateRenderPass2;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkRenderPassBeginInfo*, VkSubpassBeginInfo*, void> vkCmdBeginRenderPass2;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkSubpassBeginInfo*, VkSubpassEndInfo*, void> vkCmdNextSubpass2;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkSubpassEndInfo*, void> vkCmdEndRenderPass2;
}