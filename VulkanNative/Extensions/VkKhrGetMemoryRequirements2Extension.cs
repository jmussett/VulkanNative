namespace VulkanNative;

public unsafe class VkKhrGetMemoryRequirements2Extension
{
    public delegate* unmanaged[Cdecl]<VkDevice, VkImageMemoryRequirementsInfo2*, VkMemoryRequirements2*, void> vkGetImageMemoryRequirements2;
    public delegate* unmanaged[Cdecl]<VkDevice, VkBufferMemoryRequirementsInfo2*, VkMemoryRequirements2*, void> vkGetBufferMemoryRequirements2;
    public delegate* unmanaged[Cdecl]<VkDevice, VkImageSparseMemoryRequirementsInfo2*, uint*, VkSparseImageMemoryRequirements2*, void> vkGetImageSparseMemoryRequirements2;
}