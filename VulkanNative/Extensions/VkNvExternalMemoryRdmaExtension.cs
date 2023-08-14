namespace VulkanNative;

public unsafe class VkNvExternalMemoryRdmaExtension
{
    public delegate* unmanaged[Cdecl]<VkDevice, VkMemoryGetRemoteAddressInfoNV*, VkRemoteAddressNV*, VkResult> vkGetMemoryRemoteAddressNV;
}