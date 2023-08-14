namespace VulkanNative;

public unsafe class VkExtExtendedDynamicStateExtension
{
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCullModeFlags, void> vkCmdSetCullMode;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkFrontFace, void> vkCmdSetFrontFace;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPrimitiveTopology, void> vkCmdSetPrimitiveTopology;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, VkViewport*, void> vkCmdSetViewportWithCount;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, VkRect2D*, void> vkCmdSetScissorWithCount;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, uint, VkBuffer*, VkDeviceSize*, VkDeviceSize*, VkDeviceSize*, void> vkCmdBindVertexBuffers2;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBool32, void> vkCmdSetDepthTestEnable;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBool32, void> vkCmdSetDepthWriteEnable;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCompareOp, void> vkCmdSetDepthCompareOp;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBool32, void> vkCmdSetDepthBoundsTestEnable;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBool32, void> vkCmdSetStencilTestEnable;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkStencilFaceFlags, VkStencilOp, VkStencilOp, VkStencilOp, VkCompareOp, void> vkCmdSetStencilOp;
}