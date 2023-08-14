namespace VulkanNative;

public unsafe class VkHuaweiClusterCullingShaderExtension
{
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, uint, uint, void> vkCmdDrawClusterHUAWEI;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBuffer, VkDeviceSize, void> vkCmdDrawClusterIndirectHUAWEI;
}