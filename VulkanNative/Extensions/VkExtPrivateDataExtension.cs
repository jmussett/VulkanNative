namespace VulkanNative;

public unsafe class VkExtPrivateDataExtension
{
    public delegate* unmanaged[Cdecl]<VkDevice, VkPrivateDataSlotCreateInfo*, VkAllocationCallbacks*, VkPrivateDataSlot*, VkResult> vkCreatePrivateDataSlot;
    public delegate* unmanaged[Cdecl]<VkDevice, VkPrivateDataSlot, VkAllocationCallbacks*, void> vkDestroyPrivateDataSlot;
    public delegate* unmanaged[Cdecl]<VkDevice, VkObjectType, ulong, VkPrivateDataSlot, ulong, VkResult> vkSetPrivateData;
    public delegate* unmanaged[Cdecl]<VkDevice, VkObjectType, ulong, VkPrivateDataSlot, ulong*, void> vkGetPrivateData;
}