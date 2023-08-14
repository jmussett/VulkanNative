namespace VulkanNative;

public unsafe class VkKhrMaintenance3Extension
{
    public delegate* unmanaged[Cdecl]<VkDevice, VkDescriptorSetLayoutCreateInfo*, VkDescriptorSetLayoutSupport*, void> vkGetDescriptorSetLayoutSupport;
}