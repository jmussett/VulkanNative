﻿using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkExtTransformFeedbackExtension
{
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, uint, VkBuffer*, VkDeviceSize*, VkDeviceSize*, void> _vkCmdBindTransformFeedbackBuffersEXT;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, uint, VkBuffer*, VkDeviceSize*, void> _vkCmdBeginTransformFeedbackEXT;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, uint, VkBuffer*, VkDeviceSize*, void> _vkCmdEndTransformFeedbackEXT;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkQueryPool, uint, VkQueryControlFlags, uint, void> _vkCmdBeginQueryIndexedEXT;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkQueryPool, uint, uint, void> _vkCmdEndQueryIndexedEXT;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, uint, VkBuffer, VkDeviceSize, uint, uint, void> _vkCmdDrawIndirectByteCountEXT;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdBindTransformFeedbackBuffersEXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* pBuffers, VkDeviceSize* pOffsets, VkDeviceSize* pSizes)
    {
        _vkCmdBindTransformFeedbackBuffersEXT(commandBuffer, firstBinding, bindingCount, pBuffers, pOffsets, pSizes);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdBeginTransformFeedbackEXT(VkCommandBuffer commandBuffer, uint firstCounterBuffer, uint counterBufferCount, VkBuffer* pCounterBuffers, VkDeviceSize* pCounterBufferOffsets)
    {
        _vkCmdBeginTransformFeedbackEXT(commandBuffer, firstCounterBuffer, counterBufferCount, pCounterBuffers, pCounterBufferOffsets);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdEndTransformFeedbackEXT(VkCommandBuffer commandBuffer, uint firstCounterBuffer, uint counterBufferCount, VkBuffer* pCounterBuffers, VkDeviceSize* pCounterBufferOffsets)
    {
        _vkCmdEndTransformFeedbackEXT(commandBuffer, firstCounterBuffer, counterBufferCount, pCounterBuffers, pCounterBufferOffsets);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdBeginQueryIndexedEXT(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint query, VkQueryControlFlags flags, uint index)
    {
        _vkCmdBeginQueryIndexedEXT(commandBuffer, queryPool, query, flags, index);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdEndQueryIndexedEXT(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint query, uint index)
    {
        _vkCmdEndQueryIndexedEXT(commandBuffer, queryPool, query, index);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdDrawIndirectByteCountEXT(VkCommandBuffer commandBuffer, uint instanceCount, uint firstInstance, VkBuffer counterBuffer, VkDeviceSize counterBufferOffset, uint counterOffset, uint vertexStride)
    {
        _vkCmdDrawIndirectByteCountEXT(commandBuffer, instanceCount, firstInstance, counterBuffer, counterBufferOffset, counterOffset, vertexStride);
    }
}