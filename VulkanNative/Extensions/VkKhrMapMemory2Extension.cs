namespace VulkanNative;

public unsafe class VkKhrMapMemory2Extension
{
    public delegate* unmanaged[Cdecl]<VkDevice, VkMemoryMapInfoKHR*, void**, VkResult> vkMapMemory2KHR;
    public delegate* unmanaged[Cdecl]<VkDevice, VkMemoryUnmapInfoKHR*, VkResult> vkUnmapMemory2KHR;
}