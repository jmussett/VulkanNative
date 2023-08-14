namespace VulkanNative;

public unsafe class VkExtHostQueryResetExtension
{
    public delegate* unmanaged[Cdecl]<VkDevice, VkQueryPool, uint, uint, void> vkResetQueryPool;
}