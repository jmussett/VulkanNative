namespace VulkanNative;

public unsafe class VkExtDepthBiasControlExtension
{
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDepthBiasInfoEXT*, void> vkCmdSetDepthBias2EXT;
}