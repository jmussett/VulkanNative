namespace VulkanNative;

public unsafe class VkExtMeshShaderExtension
{
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, uint, uint, void> vkCmdDrawMeshTasksEXT;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBuffer, VkDeviceSize, uint, uint, void> vkCmdDrawMeshTasksIndirectEXT;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBuffer, VkDeviceSize, VkBuffer, VkDeviceSize, uint, uint, void> vkCmdDrawMeshTasksIndirectCountEXT;
}