namespace VulkanNative;

public unsafe class VkExtTransformFeedbackExtension
{
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, uint, VkBuffer*, VkDeviceSize*, VkDeviceSize*, void> vkCmdBindTransformFeedbackBuffersEXT;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, uint, VkBuffer*, VkDeviceSize*, void> vkCmdBeginTransformFeedbackEXT;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, uint, VkBuffer*, VkDeviceSize*, void> vkCmdEndTransformFeedbackEXT;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkQueryPool, uint, VkQueryControlFlags, uint, void> vkCmdBeginQueryIndexedEXT;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkQueryPool, uint, uint, void> vkCmdEndQueryIndexedEXT;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, uint, VkBuffer, VkDeviceSize, uint, uint, void> vkCmdDrawIndirectByteCountEXT;
}