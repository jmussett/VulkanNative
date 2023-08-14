using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkNvDeviceDiagnosticCheckpointsExtension
{
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, void*, void> _vkCmdSetCheckpointNV;
    private delegate* unmanaged[Cdecl]<VkQueue, uint*, VkCheckpointDataNV*, void> _vkGetQueueCheckpointDataNV;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdSetCheckpointNV(VkCommandBuffer commandBuffer, void* pCheckpointMarker)
    {
        _vkCmdSetCheckpointNV(commandBuffer, pCheckpointMarker);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkGetQueueCheckpointDataNV(VkQueue queue, uint* pCheckpointDataCount, VkCheckpointDataNV* pCheckpointData)
    {
        _vkGetQueueCheckpointDataNV(queue, pCheckpointDataCount, pCheckpointData);
    }
}