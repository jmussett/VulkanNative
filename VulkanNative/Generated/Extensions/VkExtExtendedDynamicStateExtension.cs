﻿using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkExtExtendedDynamicStateExtension
{
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCullModeFlags, void> _vkCmdSetCullMode;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkFrontFace, void> _vkCmdSetFrontFace;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPrimitiveTopology, void> _vkCmdSetPrimitiveTopology;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, VkViewport*, void> _vkCmdSetViewportWithCount;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, VkRect2D*, void> _vkCmdSetScissorWithCount;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, uint, VkBuffer*, VkDeviceSize*, VkDeviceSize*, VkDeviceSize*, void> _vkCmdBindVertexBuffers2;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBool32, void> _vkCmdSetDepthTestEnable;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBool32, void> _vkCmdSetDepthWriteEnable;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCompareOp, void> _vkCmdSetDepthCompareOp;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBool32, void> _vkCmdSetDepthBoundsTestEnable;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBool32, void> _vkCmdSetStencilTestEnable;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkStencilFaceFlags, VkStencilOp, VkStencilOp, VkStencilOp, VkCompareOp, void> _vkCmdSetStencilOp;

    public VkExtExtendedDynamicStateExtension(VkDevice device, IFunctionLoader loader)
    {
        _vkCmdSetCullMode = (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCullModeFlags, void>)loader.GetDeviceProcAddr(device, "vkCmdSetCullMode");
        _vkCmdSetFrontFace = (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkFrontFace, void>)loader.GetDeviceProcAddr(device, "vkCmdSetFrontFace");
        _vkCmdSetPrimitiveTopology = (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPrimitiveTopology, void>)loader.GetDeviceProcAddr(device, "vkCmdSetPrimitiveTopology");
        _vkCmdSetViewportWithCount = (delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, VkViewport*, void>)loader.GetDeviceProcAddr(device, "vkCmdSetViewportWithCount");
        _vkCmdSetScissorWithCount = (delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, VkRect2D*, void>)loader.GetDeviceProcAddr(device, "vkCmdSetScissorWithCount");
        _vkCmdBindVertexBuffers2 = (delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, uint, VkBuffer*, VkDeviceSize*, VkDeviceSize*, VkDeviceSize*, void>)loader.GetDeviceProcAddr(device, "vkCmdBindVertexBuffers2");
        _vkCmdSetDepthTestEnable = (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBool32, void>)loader.GetDeviceProcAddr(device, "vkCmdSetDepthTestEnable");
        _vkCmdSetDepthWriteEnable = (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBool32, void>)loader.GetDeviceProcAddr(device, "vkCmdSetDepthWriteEnable");
        _vkCmdSetDepthCompareOp = (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCompareOp, void>)loader.GetDeviceProcAddr(device, "vkCmdSetDepthCompareOp");
        _vkCmdSetDepthBoundsTestEnable = (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBool32, void>)loader.GetDeviceProcAddr(device, "vkCmdSetDepthBoundsTestEnable");
        _vkCmdSetStencilTestEnable = (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBool32, void>)loader.GetDeviceProcAddr(device, "vkCmdSetStencilTestEnable");
        _vkCmdSetStencilOp = (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkStencilFaceFlags, VkStencilOp, VkStencilOp, VkStencilOp, VkCompareOp, void>)loader.GetDeviceProcAddr(device, "vkCmdSetStencilOp");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void vkCmdSetCullMode(VkCommandBuffer commandBuffer, VkCullModeFlags cullMode)
    {
        _vkCmdSetCullMode(commandBuffer, cullMode);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void vkCmdSetFrontFace(VkCommandBuffer commandBuffer, VkFrontFace frontFace)
    {
        _vkCmdSetFrontFace(commandBuffer, frontFace);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void vkCmdSetPrimitiveTopology(VkCommandBuffer commandBuffer, VkPrimitiveTopology primitiveTopology)
    {
        _vkCmdSetPrimitiveTopology(commandBuffer, primitiveTopology);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void vkCmdSetViewportWithCount(VkCommandBuffer commandBuffer, uint viewportCount, VkViewport* pViewports)
    {
        _vkCmdSetViewportWithCount(commandBuffer, viewportCount, pViewports);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void vkCmdSetScissorWithCount(VkCommandBuffer commandBuffer, uint scissorCount, VkRect2D* pScissors)
    {
        _vkCmdSetScissorWithCount(commandBuffer, scissorCount, pScissors);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void vkCmdBindVertexBuffers2(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* pBuffers, VkDeviceSize* pOffsets, VkDeviceSize* pSizes, VkDeviceSize* pStrides)
    {
        _vkCmdBindVertexBuffers2(commandBuffer, firstBinding, bindingCount, pBuffers, pOffsets, pSizes, pStrides);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void vkCmdSetDepthTestEnable(VkCommandBuffer commandBuffer, VkBool32 depthTestEnable)
    {
        _vkCmdSetDepthTestEnable(commandBuffer, depthTestEnable);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void vkCmdSetDepthWriteEnable(VkCommandBuffer commandBuffer, VkBool32 depthWriteEnable)
    {
        _vkCmdSetDepthWriteEnable(commandBuffer, depthWriteEnable);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void vkCmdSetDepthCompareOp(VkCommandBuffer commandBuffer, VkCompareOp depthCompareOp)
    {
        _vkCmdSetDepthCompareOp(commandBuffer, depthCompareOp);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void vkCmdSetDepthBoundsTestEnable(VkCommandBuffer commandBuffer, VkBool32 depthBoundsTestEnable)
    {
        _vkCmdSetDepthBoundsTestEnable(commandBuffer, depthBoundsTestEnable);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void vkCmdSetStencilTestEnable(VkCommandBuffer commandBuffer, VkBool32 stencilTestEnable)
    {
        _vkCmdSetStencilTestEnable(commandBuffer, stencilTestEnable);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void vkCmdSetStencilOp(VkCommandBuffer commandBuffer, VkStencilFaceFlags faceMask, VkStencilOp failOp, VkStencilOp passOp, VkStencilOp depthFailOp, VkCompareOp compareOp)
    {
        _vkCmdSetStencilOp(commandBuffer, faceMask, failOp, passOp, depthFailOp, compareOp);
    }
}