using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkNvMeshShaderExtension
{
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, uint, void> _vkCmdDrawMeshTasksNV;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBuffer, VkDeviceSize, uint, uint, void> _vkCmdDrawMeshTasksIndirectNV;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBuffer, VkDeviceSize, VkBuffer, VkDeviceSize, uint, uint, void> _vkCmdDrawMeshTasksIndirectCountNV;

    public VkNvMeshShaderExtension(VkDevice device, IFunctionLoader loader)
    {
        _vkCmdDrawMeshTasksNV = (delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, uint, void>)loader.GetDeviceProcAddr(device, "vkCmdDrawMeshTasksNV");
        _vkCmdDrawMeshTasksIndirectNV = (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBuffer, VkDeviceSize, uint, uint, void>)loader.GetDeviceProcAddr(device, "vkCmdDrawMeshTasksIndirectNV");
        _vkCmdDrawMeshTasksIndirectCountNV = (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBuffer, VkDeviceSize, VkBuffer, VkDeviceSize, uint, uint, void>)loader.GetDeviceProcAddr(device, "vkCmdDrawMeshTasksIndirectCountNV");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void vkCmdDrawMeshTasksNV(VkCommandBuffer commandBuffer, uint taskCount, uint firstTask)
    {
        _vkCmdDrawMeshTasksNV(commandBuffer, taskCount, firstTask);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void vkCmdDrawMeshTasksIndirectNV(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, uint drawCount, uint stride)
    {
        _vkCmdDrawMeshTasksIndirectNV(commandBuffer, buffer, offset, drawCount, stride);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void vkCmdDrawMeshTasksIndirectCountNV(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, VkBuffer countBuffer, VkDeviceSize countBufferOffset, uint maxDrawCount, uint stride)
    {
        _vkCmdDrawMeshTasksIndirectCountNV(commandBuffer, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);
    }
}