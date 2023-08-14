namespace VulkanNative;

public unsafe class VkExtVertexInputDynamicStateExtension
{
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, VkVertexInputBindingDescription2EXT*, uint, VkVertexInputAttributeDescription2EXT*, void> vkCmdSetVertexInputEXT;
}