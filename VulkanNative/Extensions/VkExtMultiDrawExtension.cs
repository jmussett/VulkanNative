namespace VulkanNative;

public unsafe class VkExtMultiDrawExtension
{
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, VkMultiDrawInfoEXT*, uint, uint, uint, void> vkCmdDrawMultiEXT;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, VkMultiDrawIndexedInfoEXT*, uint, uint, uint, int*, void> vkCmdDrawMultiIndexedEXT;
}