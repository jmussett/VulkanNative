namespace VulkanNative;

public unsafe class VkNvMemoryDecompressionExtension
{
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, VkDecompressMemoryRegionNV*, void> vkCmdDecompressMemoryNV;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDeviceAddress, VkDeviceAddress, uint, void> vkCmdDecompressMemoryIndirectCountNV;
}