namespace VulkanNative;

public unsafe class VkExtColorWriteEnableExtension
{
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, VkBool32*, void> vkCmdSetColorWriteEnableEXT;
}