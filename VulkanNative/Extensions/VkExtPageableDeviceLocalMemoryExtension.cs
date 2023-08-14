namespace VulkanNative;

public unsafe class VkExtPageableDeviceLocalMemoryExtension
{
    public delegate* unmanaged[Cdecl]<VkDevice, VkDeviceMemory, float, void> vkSetDeviceMemoryPriorityEXT;
}