namespace VulkanNative;

public unsafe class VkExtDiscardRectanglesExtension
{
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, uint, VkRect2D*, void> vkCmdSetDiscardRectangleEXT;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBool32, void> vkCmdSetDiscardRectangleEnableEXT;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDiscardRectangleModeEXT, void> vkCmdSetDiscardRectangleModeEXT;
}