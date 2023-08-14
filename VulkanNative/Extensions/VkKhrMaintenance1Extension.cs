namespace VulkanNative;

public unsafe class VkKhrMaintenance1Extension
{
    public delegate* unmanaged[Cdecl]<VkDevice, VkCommandPool, VkCommandPoolTrimFlags, void> vkTrimCommandPool;
}