﻿using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkExtMultiDrawExtension
{
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, VkMultiDrawInfoEXT*, uint, uint, uint, void> _vkCmdDrawMultiEXT;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, VkMultiDrawIndexedInfoEXT*, uint, uint, uint, int*, void> _vkCmdDrawMultiIndexedEXT;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdDrawMultiEXT(VkCommandBuffer commandBuffer, uint drawCount, VkMultiDrawInfoEXT* pVertexInfo, uint instanceCount, uint firstInstance, uint stride)
    {
        _vkCmdDrawMultiEXT(commandBuffer, drawCount, pVertexInfo, instanceCount, firstInstance, stride);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdDrawMultiIndexedEXT(VkCommandBuffer commandBuffer, uint drawCount, VkMultiDrawIndexedInfoEXT* pIndexInfo, uint instanceCount, uint firstInstance, uint stride, int* pVertexOffset)
    {
        _vkCmdDrawMultiIndexedEXT(commandBuffer, drawCount, pIndexInfo, instanceCount, firstInstance, stride, pVertexOffset);
    }
}