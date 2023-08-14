namespace VulkanNative;

public unsafe class VkKhrMaintenance4Extension
{
    public delegate* unmanaged[Cdecl]<VkDevice, VkDeviceBufferMemoryRequirements*, VkMemoryRequirements2*, void> vkGetDeviceBufferMemoryRequirements;
    public delegate* unmanaged[Cdecl]<VkDevice, VkDeviceImageMemoryRequirements*, VkMemoryRequirements2*, void> vkGetDeviceImageMemoryRequirements;
    public delegate* unmanaged[Cdecl]<VkDevice, VkDeviceImageMemoryRequirements*, uint*, VkSparseImageMemoryRequirements2*, void> vkGetDeviceImageSparseMemoryRequirements;
}