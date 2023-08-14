namespace VulkanNative;

public unsafe class VkExtConditionalRenderingExtension
{
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkConditionalRenderingBeginInfoEXT*, void> vkCmdBeginConditionalRenderingEXT;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, void> vkCmdEndConditionalRenderingEXT;
}