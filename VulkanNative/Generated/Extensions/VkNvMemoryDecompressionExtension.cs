using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkNvMemoryDecompressionExtension
{
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, VkDecompressMemoryRegionNV*, void> _vkCmdDecompressMemoryNV;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDeviceAddress, VkDeviceAddress, uint, void> _vkCmdDecompressMemoryIndirectCountNV;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdDecompressMemoryNV(VkCommandBuffer commandBuffer, uint decompressRegionCount, VkDecompressMemoryRegionNV* pDecompressMemoryRegions)
    {
        _vkCmdDecompressMemoryNV(commandBuffer, decompressRegionCount, pDecompressMemoryRegions);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdDecompressMemoryIndirectCountNV(VkCommandBuffer commandBuffer, VkDeviceAddress indirectCommandsAddress, VkDeviceAddress indirectCommandsCountAddress, uint stride)
    {
        _vkCmdDecompressMemoryIndirectCountNV(commandBuffer, indirectCommandsAddress, indirectCommandsCountAddress, stride);
    }
}