namespace VulkanNative;

public unsafe class VkExtLineRasterizationExtension
{
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, ushort, void> vkCmdSetLineStippleEXT;
}