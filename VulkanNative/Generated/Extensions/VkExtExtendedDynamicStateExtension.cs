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

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdSetCullMode(VkCommandBuffer commandBuffer, VkCullModeFlags cullMode)
    {
        _vkCmdSetCullMode(commandBuffer, cullMode);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdSetFrontFace(VkCommandBuffer commandBuffer, VkFrontFace frontFace)
    {
        _vkCmdSetFrontFace(commandBuffer, frontFace);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdSetPrimitiveTopology(VkCommandBuffer commandBuffer, VkPrimitiveTopology primitiveTopology)
    {
        _vkCmdSetPrimitiveTopology(commandBuffer, primitiveTopology);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdSetViewportWithCount(VkCommandBuffer commandBuffer, uint viewportCount, VkViewport* pViewports)
    {
        _vkCmdSetViewportWithCount(commandBuffer, viewportCount, pViewports);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdSetScissorWithCount(VkCommandBuffer commandBuffer, uint scissorCount, VkRect2D* pScissors)
    {
        _vkCmdSetScissorWithCount(commandBuffer, scissorCount, pScissors);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdBindVertexBuffers2(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* pBuffers, VkDeviceSize* pOffsets, VkDeviceSize* pSizes, VkDeviceSize* pStrides)
    {
        _vkCmdBindVertexBuffers2(commandBuffer, firstBinding, bindingCount, pBuffers, pOffsets, pSizes, pStrides);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdSetDepthTestEnable(VkCommandBuffer commandBuffer, VkBool32 depthTestEnable)
    {
        _vkCmdSetDepthTestEnable(commandBuffer, depthTestEnable);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdSetDepthWriteEnable(VkCommandBuffer commandBuffer, VkBool32 depthWriteEnable)
    {
        _vkCmdSetDepthWriteEnable(commandBuffer, depthWriteEnable);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdSetDepthCompareOp(VkCommandBuffer commandBuffer, VkCompareOp depthCompareOp)
    {
        _vkCmdSetDepthCompareOp(commandBuffer, depthCompareOp);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdSetDepthBoundsTestEnable(VkCommandBuffer commandBuffer, VkBool32 depthBoundsTestEnable)
    {
        _vkCmdSetDepthBoundsTestEnable(commandBuffer, depthBoundsTestEnable);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdSetStencilTestEnable(VkCommandBuffer commandBuffer, VkBool32 stencilTestEnable)
    {
        _vkCmdSetStencilTestEnable(commandBuffer, stencilTestEnable);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdSetStencilOp(VkCommandBuffer commandBuffer, VkStencilFaceFlags faceMask, VkStencilOp failOp, VkStencilOp passOp, VkStencilOp depthFailOp, VkCompareOp compareOp)
    {
        _vkCmdSetStencilOp(commandBuffer, faceMask, failOp, passOp, depthFailOp, compareOp);
    }
}