﻿using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkExtMeshShaderExtension
{
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, uint, uint, void> _vkCmdDrawMeshTasksEXT;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBuffer, VkDeviceSize, uint, uint, void> _vkCmdDrawMeshTasksIndirectEXT;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBuffer, VkDeviceSize, VkBuffer, VkDeviceSize, uint, uint, void> _vkCmdDrawMeshTasksIndirectCountEXT;

    public VkExtMeshShaderExtension(VkDevice device, IFunctionLoader loader)
    {
        _vkCmdDrawMeshTasksEXT = (delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, uint, uint, void>)loader.GetDeviceProcAddr(device, "vkCmdDrawMeshTasksEXT");
        _vkCmdDrawMeshTasksIndirectEXT = (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBuffer, VkDeviceSize, uint, uint, void>)loader.GetDeviceProcAddr(device, "vkCmdDrawMeshTasksIndirectEXT");
        _vkCmdDrawMeshTasksIndirectCountEXT = (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBuffer, VkDeviceSize, VkBuffer, VkDeviceSize, uint, uint, void>)loader.GetDeviceProcAddr(device, "vkCmdDrawMeshTasksIndirectCountEXT");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void vkCmdDrawMeshTasksEXT(VkCommandBuffer commandBuffer, uint groupCountX, uint groupCountY, uint groupCountZ)
    {
        _vkCmdDrawMeshTasksEXT(commandBuffer, groupCountX, groupCountY, groupCountZ);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void vkCmdDrawMeshTasksIndirectEXT(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, uint drawCount, uint stride)
    {
        _vkCmdDrawMeshTasksIndirectEXT(commandBuffer, buffer, offset, drawCount, stride);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void vkCmdDrawMeshTasksIndirectCountEXT(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, VkBuffer countBuffer, VkDeviceSize countBufferOffset, uint maxDrawCount, uint stride)
    {
        _vkCmdDrawMeshTasksIndirectCountEXT(commandBuffer, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);
    }
}