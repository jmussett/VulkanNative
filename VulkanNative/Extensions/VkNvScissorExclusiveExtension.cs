namespace VulkanNative;

public unsafe class VkNvScissorExclusiveExtension
{
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, uint, VkBool32*, void> vkCmdSetExclusiveScissorEnableNV;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, uint, VkRect2D*, void> vkCmdSetExclusiveScissorNV;
}