namespace VulkanNative;

public unsafe class VkKhrBufferDeviceAddressExtension
{
    public delegate* unmanaged[Cdecl]<VkDevice, VkBufferDeviceAddressInfo*, VkDeviceAddress> vkGetBufferDeviceAddress;
    public delegate* unmanaged[Cdecl]<VkDevice, VkBufferDeviceAddressInfo*, ulong> vkGetBufferOpaqueCaptureAddress;
    public delegate* unmanaged[Cdecl]<VkDevice, VkDeviceMemoryOpaqueCaptureAddressInfo*, ulong> vkGetDeviceMemoryOpaqueCaptureAddress;
}