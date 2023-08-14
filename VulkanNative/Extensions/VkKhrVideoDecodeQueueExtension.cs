namespace VulkanNative;

public unsafe class VkKhrVideoDecodeQueueExtension
{
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkVideoDecodeInfoKHR*, void> vkCmdDecodeVideoKHR;
}