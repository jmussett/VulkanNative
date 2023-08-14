namespace VulkanNative;

public unsafe class VkKhrTimelineSemaphoreExtension
{
    public delegate* unmanaged[Cdecl]<VkDevice, VkSemaphore, ulong*, VkResult> vkGetSemaphoreCounterValue;
    public delegate* unmanaged[Cdecl]<VkDevice, VkSemaphoreWaitInfo*, ulong, VkResult> vkWaitSemaphores;
    public delegate* unmanaged[Cdecl]<VkDevice, VkSemaphoreSignalInfo*, VkResult> vkSignalSemaphore;
}