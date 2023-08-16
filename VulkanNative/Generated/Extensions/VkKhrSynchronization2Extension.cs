using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkKhrSynchronization2Extension
{
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkEvent, VkDependencyInfo*, void> _vkCmdSetEvent2;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkEvent, VkPipelineStageFlags2, void> _vkCmdResetEvent2;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, VkEvent*, VkDependencyInfo*, void> _vkCmdWaitEvents2;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDependencyInfo*, void> _vkCmdPipelineBarrier2;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPipelineStageFlags2, VkQueryPool, uint, void> _vkCmdWriteTimestamp2;
    private delegate* unmanaged[Cdecl]<VkQueue, uint, VkSubmitInfo2*, VkFence, VkResult> _vkQueueSubmit2;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPipelineStageFlags2, VkBuffer, VkDeviceSize, uint, void> _vkCmdWriteBufferMarker2AMD;
    private delegate* unmanaged[Cdecl]<VkQueue, uint*, VkCheckpointData2NV*, void> _vkGetQueueCheckpointData2NV;

    public VkKhrSynchronization2Extension(VkDevice device, IFunctionLoader loader)
    {
        _vkCmdSetEvent2 = (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkEvent, VkDependencyInfo*, void>)loader.GetDeviceProcAddr(device, "vkCmdSetEvent2");
        _vkCmdResetEvent2 = (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkEvent, VkPipelineStageFlags2, void>)loader.GetDeviceProcAddr(device, "vkCmdResetEvent2");
        _vkCmdWaitEvents2 = (delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, VkEvent*, VkDependencyInfo*, void>)loader.GetDeviceProcAddr(device, "vkCmdWaitEvents2");
        _vkCmdPipelineBarrier2 = (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDependencyInfo*, void>)loader.GetDeviceProcAddr(device, "vkCmdPipelineBarrier2");
        _vkCmdWriteTimestamp2 = (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPipelineStageFlags2, VkQueryPool, uint, void>)loader.GetDeviceProcAddr(device, "vkCmdWriteTimestamp2");
        _vkQueueSubmit2 = (delegate* unmanaged[Cdecl]<VkQueue, uint, VkSubmitInfo2*, VkFence, VkResult>)loader.GetDeviceProcAddr(device, "vkQueueSubmit2");
        _vkCmdWriteBufferMarker2AMD = (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPipelineStageFlags2, VkBuffer, VkDeviceSize, uint, void>)loader.GetDeviceProcAddr(device, "vkCmdWriteBufferMarker2AMD");
        _vkGetQueueCheckpointData2NV = (delegate* unmanaged[Cdecl]<VkQueue, uint*, VkCheckpointData2NV*, void>)loader.GetDeviceProcAddr(device, "vkGetQueueCheckpointData2NV");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdSetEvent2(VkCommandBuffer commandBuffer, VkEvent @event, VkDependencyInfo* pDependencyInfo)
    {
        _vkCmdSetEvent2(commandBuffer, @event, pDependencyInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdResetEvent2(VkCommandBuffer commandBuffer, VkEvent @event, VkPipelineStageFlags2 stageMask)
    {
        _vkCmdResetEvent2(commandBuffer, @event, stageMask);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdWaitEvents2(VkCommandBuffer commandBuffer, uint eventCount, VkEvent* pEvents, VkDependencyInfo* pDependencyInfos)
    {
        _vkCmdWaitEvents2(commandBuffer, eventCount, pEvents, pDependencyInfos);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdPipelineBarrier2(VkCommandBuffer commandBuffer, VkDependencyInfo* pDependencyInfo)
    {
        _vkCmdPipelineBarrier2(commandBuffer, pDependencyInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdWriteTimestamp2(VkCommandBuffer commandBuffer, VkPipelineStageFlags2 stage, VkQueryPool queryPool, uint query)
    {
        _vkCmdWriteTimestamp2(commandBuffer, stage, queryPool, query);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkQueueSubmit2(VkQueue queue, uint submitCount, VkSubmitInfo2* pSubmits, VkFence fence)
    {
        return _vkQueueSubmit2(queue, submitCount, pSubmits, fence);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdWriteBufferMarker2AMD(VkCommandBuffer commandBuffer, VkPipelineStageFlags2 stage, VkBuffer dstBuffer, VkDeviceSize dstOffset, uint marker)
    {
        _vkCmdWriteBufferMarker2AMD(commandBuffer, stage, dstBuffer, dstOffset, marker);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkGetQueueCheckpointData2NV(VkQueue queue, uint* pCheckpointDataCount, VkCheckpointData2NV* pCheckpointData)
    {
        _vkGetQueueCheckpointData2NV(queue, pCheckpointDataCount, pCheckpointData);
    }
}