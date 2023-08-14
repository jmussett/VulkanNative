namespace VulkanNative;

public unsafe class VkKhrBindMemory2Extension
{
    public delegate* unmanaged[Cdecl]<VkDevice, uint, VkBindBufferMemoryInfo*, VkResult> vkBindBufferMemory2;
    public delegate* unmanaged[Cdecl]<VkDevice, uint, VkBindImageMemoryInfo*, VkResult> vkBindImageMemory2;
}