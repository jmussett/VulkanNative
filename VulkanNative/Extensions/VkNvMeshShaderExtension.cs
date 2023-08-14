namespace VulkanNative;

public unsafe class VkNvMeshShaderExtension
{
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, uint, void> vkCmdDrawMeshTasksNV;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBuffer, VkDeviceSize, uint, uint, void> vkCmdDrawMeshTasksIndirectNV;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBuffer, VkDeviceSize, VkBuffer, VkDeviceSize, uint, uint, void> vkCmdDrawMeshTasksIndirectCountNV;
}