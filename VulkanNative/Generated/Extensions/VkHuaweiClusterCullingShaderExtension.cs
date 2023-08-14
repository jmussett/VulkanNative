﻿using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkHuaweiClusterCullingShaderExtension
{
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, uint, uint, void> _vkCmdDrawClusterHUAWEI;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBuffer, VkDeviceSize, void> _vkCmdDrawClusterIndirectHUAWEI;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdDrawClusterHUAWEI(VkCommandBuffer commandBuffer, uint groupCountX, uint groupCountY, uint groupCountZ)
    {
        _vkCmdDrawClusterHUAWEI(commandBuffer, groupCountX, groupCountY, groupCountZ);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdDrawClusterIndirectHUAWEI(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset)
    {
        _vkCmdDrawClusterIndirectHUAWEI(commandBuffer, buffer, offset);
    }
}