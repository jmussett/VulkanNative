namespace VulkanNative;

public unsafe class VkExtExtendedDynamicState2Extension
{
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, void> vkCmdSetPatchControlPointsEXT;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBool32, void> vkCmdSetRasterizerDiscardEnable;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBool32, void> vkCmdSetDepthBiasEnable;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkLogicOp, void> vkCmdSetLogicOpEXT;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBool32, void> vkCmdSetPrimitiveRestartEnable;
}