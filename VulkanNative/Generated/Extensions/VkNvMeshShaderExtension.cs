using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkNvMeshShaderExtension
{
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, uint, void> _vkCmdDrawMeshTasksNV;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBuffer, VkDeviceSize, uint, uint, void> _vkCmdDrawMeshTasksIndirectNV;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBuffer, VkDeviceSize, VkBuffer, VkDeviceSize, uint, uint, void> _vkCmdDrawMeshTasksIndirectCountNV;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdDrawMeshTasksNV(VkCommandBuffer commandBuffer, uint taskCount, uint firstTask)
    {
        _vkCmdDrawMeshTasksNV(commandBuffer, taskCount, firstTask);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdDrawMeshTasksIndirectNV(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, uint drawCount, uint stride)
    {
        _vkCmdDrawMeshTasksIndirectNV(commandBuffer, buffer, offset, drawCount, stride);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdDrawMeshTasksIndirectCountNV(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, VkBuffer countBuffer, VkDeviceSize countBufferOffset, uint maxDrawCount, uint stride)
    {
        _vkCmdDrawMeshTasksIndirectCountNV(commandBuffer, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);
    }
}