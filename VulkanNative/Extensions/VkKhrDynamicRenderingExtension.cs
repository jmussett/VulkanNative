namespace VulkanNative;

public unsafe class VkKhrDynamicRenderingExtension
{
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkRenderingInfo*, void> vkCmdBeginRendering;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, void> vkCmdEndRendering;
}