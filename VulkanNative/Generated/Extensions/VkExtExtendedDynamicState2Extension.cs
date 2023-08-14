﻿using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkExtExtendedDynamicState2Extension
{
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, void> _vkCmdSetPatchControlPointsEXT;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBool32, void> _vkCmdSetRasterizerDiscardEnable;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBool32, void> _vkCmdSetDepthBiasEnable;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkLogicOp, void> _vkCmdSetLogicOpEXT;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBool32, void> _vkCmdSetPrimitiveRestartEnable;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdSetPatchControlPointsEXT(VkCommandBuffer commandBuffer, uint patchControlPoints)
    {
        _vkCmdSetPatchControlPointsEXT(commandBuffer, patchControlPoints);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdSetRasterizerDiscardEnable(VkCommandBuffer commandBuffer, VkBool32 rasterizerDiscardEnable)
    {
        _vkCmdSetRasterizerDiscardEnable(commandBuffer, rasterizerDiscardEnable);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdSetDepthBiasEnable(VkCommandBuffer commandBuffer, VkBool32 depthBiasEnable)
    {
        _vkCmdSetDepthBiasEnable(commandBuffer, depthBiasEnable);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdSetLogicOpEXT(VkCommandBuffer commandBuffer, VkLogicOp logicOp)
    {
        _vkCmdSetLogicOpEXT(commandBuffer, logicOp);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdSetPrimitiveRestartEnable(VkCommandBuffer commandBuffer, VkBool32 primitiveRestartEnable)
    {
        _vkCmdSetPrimitiveRestartEnable(commandBuffer, primitiveRestartEnable);
    }
}