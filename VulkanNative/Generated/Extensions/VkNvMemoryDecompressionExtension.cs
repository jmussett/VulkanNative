﻿using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkNvMemoryDecompressionExtension
{
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, VkDecompressMemoryRegionNV*, void> _vkCmdDecompressMemoryNV;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDeviceAddress, VkDeviceAddress, uint, void> _vkCmdDecompressMemoryIndirectCountNV;

    public VkNvMemoryDecompressionExtension(VkDevice device, IFunctionLoader loader)
    {
        _vkCmdDecompressMemoryNV = (delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, VkDecompressMemoryRegionNV*, void>)loader.GetDeviceProcAddr(device, "vkCmdDecompressMemoryNV");
        _vkCmdDecompressMemoryIndirectCountNV = (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDeviceAddress, VkDeviceAddress, uint, void>)loader.GetDeviceProcAddr(device, "vkCmdDecompressMemoryIndirectCountNV");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void vkCmdDecompressMemoryNV(VkCommandBuffer commandBuffer, uint decompressRegionCount, VkDecompressMemoryRegionNV* pDecompressMemoryRegions)
    {
        _vkCmdDecompressMemoryNV(commandBuffer, decompressRegionCount, pDecompressMemoryRegions);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void vkCmdDecompressMemoryIndirectCountNV(VkCommandBuffer commandBuffer, VkDeviceAddress indirectCommandsAddress, VkDeviceAddress indirectCommandsCountAddress, uint stride)
    {
        _vkCmdDecompressMemoryIndirectCountNV(commandBuffer, indirectCommandsAddress, indirectCommandsCountAddress, stride);
    }
}