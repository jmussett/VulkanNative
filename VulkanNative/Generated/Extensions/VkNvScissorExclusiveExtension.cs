﻿using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkNvScissorExclusiveExtension
{
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, uint, VkBool32*, void> _vkCmdSetExclusiveScissorEnableNV;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, uint, VkRect2D*, void> _vkCmdSetExclusiveScissorNV;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdSetExclusiveScissorEnableNV(VkCommandBuffer commandBuffer, uint firstExclusiveScissor, uint exclusiveScissorCount, VkBool32* pExclusiveScissorEnables)
    {
        _vkCmdSetExclusiveScissorEnableNV(commandBuffer, firstExclusiveScissor, exclusiveScissorCount, pExclusiveScissorEnables);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdSetExclusiveScissorNV(VkCommandBuffer commandBuffer, uint firstExclusiveScissor, uint exclusiveScissorCount, VkRect2D* pExclusiveScissors)
    {
        _vkCmdSetExclusiveScissorNV(commandBuffer, firstExclusiveScissor, exclusiveScissorCount, pExclusiveScissors);
    }
}