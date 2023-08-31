using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkNvDeviceDiagnosticCheckpointsExtension
{
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, void*, void> _vkCmdSetCheckpointNV;
    private delegate* unmanaged[Cdecl]<VkQueue, uint*, VkCheckpointDataNV*, void> _vkGetQueueCheckpointDataNV;

    public VkNvDeviceDiagnosticCheckpointsExtension(VkDevice device, IFunctionLoader loader)
    {
        _vkCmdSetCheckpointNV = (delegate* unmanaged[Cdecl]<VkCommandBuffer, void*, void>)loader.GetDeviceProcAddr(device, "vkCmdSetCheckpointNV");
        _vkGetQueueCheckpointDataNV = (delegate* unmanaged[Cdecl]<VkQueue, uint*, VkCheckpointDataNV*, void>)loader.GetDeviceProcAddr(device, "vkGetQueueCheckpointDataNV");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void vkCmdSetCheckpointNV(VkCommandBuffer commandBuffer, void* pCheckpointMarker)
    {
        _vkCmdSetCheckpointNV(commandBuffer, pCheckpointMarker);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void vkGetQueueCheckpointDataNV(VkQueue queue, uint* pCheckpointDataCount, VkCheckpointDataNV* pCheckpointData)
    {
        _vkGetQueueCheckpointDataNV(queue, pCheckpointDataCount, pCheckpointData);
    }
}