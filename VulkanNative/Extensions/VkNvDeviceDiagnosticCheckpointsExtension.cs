namespace VulkanNative;

public unsafe class VkNvDeviceDiagnosticCheckpointsExtension
{
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, void*, void> vkCmdSetCheckpointNV;
    public delegate* unmanaged[Cdecl]<VkQueue, uint*, VkCheckpointDataNV*, void> vkGetQueueCheckpointDataNV;
}