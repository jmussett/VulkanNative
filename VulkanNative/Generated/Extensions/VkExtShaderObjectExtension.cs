using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkExtShaderObjectExtension
{
    private delegate* unmanaged[Cdecl]<VkDevice, uint, VkShaderCreateInfoEXT*, VkAllocationCallbacks*, VkShaderEXT*, VkResult> _vkCreateShadersEXT;
    private delegate* unmanaged[Cdecl]<VkDevice, VkShaderEXT, VkAllocationCallbacks*, void> _vkDestroyShaderEXT;
    private delegate* unmanaged[Cdecl]<VkDevice, VkShaderEXT, nint*, void*, VkResult> _vkGetShaderBinaryDataEXT;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, VkShaderStageFlags*, VkShaderEXT*, void> _vkCmdBindShadersEXT;
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
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, VkVertexInputBindingDescription2EXT*, uint, VkVertexInputAttributeDescription2EXT*, void> _vkCmdSetVertexInputEXT;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, void> _vkCmdSetPatchControlPointsEXT;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBool32, void> _vkCmdSetRasterizerDiscardEnable;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBool32, void> _vkCmdSetDepthBiasEnable;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkLogicOp, void> _vkCmdSetLogicOpEXT;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBool32, void> _vkCmdSetPrimitiveRestartEnable;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkTessellationDomainOrigin, void> _vkCmdSetTessellationDomainOriginEXT;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBool32, void> _vkCmdSetDepthClampEnableEXT;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPolygonMode, void> _vkCmdSetPolygonModeEXT;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkSampleCountFlags, void> _vkCmdSetRasterizationSamplesEXT;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkSampleCountFlags, VkSampleMask*, void> _vkCmdSetSampleMaskEXT;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBool32, void> _vkCmdSetAlphaToCoverageEnableEXT;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBool32, void> _vkCmdSetAlphaToOneEnableEXT;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBool32, void> _vkCmdSetLogicOpEnableEXT;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, uint, VkBool32*, void> _vkCmdSetColorBlendEnableEXT;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, uint, VkColorBlendEquationEXT*, void> _vkCmdSetColorBlendEquationEXT;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, uint, VkColorComponentFlags*, void> _vkCmdSetColorWriteMaskEXT;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, void> _vkCmdSetRasterizationStreamEXT;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkConservativeRasterizationModeEXT, void> _vkCmdSetConservativeRasterizationModeEXT;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, float, void> _vkCmdSetExtraPrimitiveOverestimationSizeEXT;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBool32, void> _vkCmdSetDepthClipEnableEXT;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBool32, void> _vkCmdSetSampleLocationsEnableEXT;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, uint, VkColorBlendAdvancedEXT*, void> _vkCmdSetColorBlendAdvancedEXT;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkProvokingVertexModeEXT, void> _vkCmdSetProvokingVertexModeEXT;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkLineRasterizationModeEXT, void> _vkCmdSetLineRasterizationModeEXT;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBool32, void> _vkCmdSetLineStippleEnableEXT;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBool32, void> _vkCmdSetDepthClipNegativeOneToOneEXT;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBool32, void> _vkCmdSetViewportWScalingEnableNV;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, uint, VkViewportSwizzleNV*, void> _vkCmdSetViewportSwizzleNV;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBool32, void> _vkCmdSetCoverageToColorEnableNV;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, void> _vkCmdSetCoverageToColorLocationNV;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCoverageModulationModeNV, void> _vkCmdSetCoverageModulationModeNV;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBool32, void> _vkCmdSetCoverageModulationTableEnableNV;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, float*, void> _vkCmdSetCoverageModulationTableNV;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBool32, void> _vkCmdSetShadingRateImageEnableNV;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBool32, void> _vkCmdSetRepresentativeFragmentTestEnableNV;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCoverageReductionModeNV, void> _vkCmdSetCoverageReductionModeNV;

    public VkExtShaderObjectExtension(VkDevice device, IFunctionLoader loader)
    {
        _vkCreateShadersEXT = (delegate* unmanaged[Cdecl]<VkDevice, uint, VkShaderCreateInfoEXT*, VkAllocationCallbacks*, VkShaderEXT*, VkResult>)loader.GetDeviceProcAddr(device, "vkCreateShadersEXT");
        _vkDestroyShaderEXT = (delegate* unmanaged[Cdecl]<VkDevice, VkShaderEXT, VkAllocationCallbacks*, void>)loader.GetDeviceProcAddr(device, "vkDestroyShaderEXT");
        _vkGetShaderBinaryDataEXT = (delegate* unmanaged[Cdecl]<VkDevice, VkShaderEXT, nint*, void*, VkResult>)loader.GetDeviceProcAddr(device, "vkGetShaderBinaryDataEXT");
        _vkCmdBindShadersEXT = (delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, VkShaderStageFlags*, VkShaderEXT*, void>)loader.GetDeviceProcAddr(device, "vkCmdBindShadersEXT");
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
        _vkCmdSetVertexInputEXT = (delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, VkVertexInputBindingDescription2EXT*, uint, VkVertexInputAttributeDescription2EXT*, void>)loader.GetDeviceProcAddr(device, "vkCmdSetVertexInputEXT");
        _vkCmdSetPatchControlPointsEXT = (delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, void>)loader.GetDeviceProcAddr(device, "vkCmdSetPatchControlPointsEXT");
        _vkCmdSetRasterizerDiscardEnable = (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBool32, void>)loader.GetDeviceProcAddr(device, "vkCmdSetRasterizerDiscardEnable");
        _vkCmdSetDepthBiasEnable = (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBool32, void>)loader.GetDeviceProcAddr(device, "vkCmdSetDepthBiasEnable");
        _vkCmdSetLogicOpEXT = (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkLogicOp, void>)loader.GetDeviceProcAddr(device, "vkCmdSetLogicOpEXT");
        _vkCmdSetPrimitiveRestartEnable = (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBool32, void>)loader.GetDeviceProcAddr(device, "vkCmdSetPrimitiveRestartEnable");
        _vkCmdSetTessellationDomainOriginEXT = (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkTessellationDomainOrigin, void>)loader.GetDeviceProcAddr(device, "vkCmdSetTessellationDomainOriginEXT");
        _vkCmdSetDepthClampEnableEXT = (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBool32, void>)loader.GetDeviceProcAddr(device, "vkCmdSetDepthClampEnableEXT");
        _vkCmdSetPolygonModeEXT = (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPolygonMode, void>)loader.GetDeviceProcAddr(device, "vkCmdSetPolygonModeEXT");
        _vkCmdSetRasterizationSamplesEXT = (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkSampleCountFlags, void>)loader.GetDeviceProcAddr(device, "vkCmdSetRasterizationSamplesEXT");
        _vkCmdSetSampleMaskEXT = (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkSampleCountFlags, VkSampleMask*, void>)loader.GetDeviceProcAddr(device, "vkCmdSetSampleMaskEXT");
        _vkCmdSetAlphaToCoverageEnableEXT = (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBool32, void>)loader.GetDeviceProcAddr(device, "vkCmdSetAlphaToCoverageEnableEXT");
        _vkCmdSetAlphaToOneEnableEXT = (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBool32, void>)loader.GetDeviceProcAddr(device, "vkCmdSetAlphaToOneEnableEXT");
        _vkCmdSetLogicOpEnableEXT = (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBool32, void>)loader.GetDeviceProcAddr(device, "vkCmdSetLogicOpEnableEXT");
        _vkCmdSetColorBlendEnableEXT = (delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, uint, VkBool32*, void>)loader.GetDeviceProcAddr(device, "vkCmdSetColorBlendEnableEXT");
        _vkCmdSetColorBlendEquationEXT = (delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, uint, VkColorBlendEquationEXT*, void>)loader.GetDeviceProcAddr(device, "vkCmdSetColorBlendEquationEXT");
        _vkCmdSetColorWriteMaskEXT = (delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, uint, VkColorComponentFlags*, void>)loader.GetDeviceProcAddr(device, "vkCmdSetColorWriteMaskEXT");
        _vkCmdSetRasterizationStreamEXT = (delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, void>)loader.GetDeviceProcAddr(device, "vkCmdSetRasterizationStreamEXT");
        _vkCmdSetConservativeRasterizationModeEXT = (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkConservativeRasterizationModeEXT, void>)loader.GetDeviceProcAddr(device, "vkCmdSetConservativeRasterizationModeEXT");
        _vkCmdSetExtraPrimitiveOverestimationSizeEXT = (delegate* unmanaged[Cdecl]<VkCommandBuffer, float, void>)loader.GetDeviceProcAddr(device, "vkCmdSetExtraPrimitiveOverestimationSizeEXT");
        _vkCmdSetDepthClipEnableEXT = (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBool32, void>)loader.GetDeviceProcAddr(device, "vkCmdSetDepthClipEnableEXT");
        _vkCmdSetSampleLocationsEnableEXT = (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBool32, void>)loader.GetDeviceProcAddr(device, "vkCmdSetSampleLocationsEnableEXT");
        _vkCmdSetColorBlendAdvancedEXT = (delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, uint, VkColorBlendAdvancedEXT*, void>)loader.GetDeviceProcAddr(device, "vkCmdSetColorBlendAdvancedEXT");
        _vkCmdSetProvokingVertexModeEXT = (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkProvokingVertexModeEXT, void>)loader.GetDeviceProcAddr(device, "vkCmdSetProvokingVertexModeEXT");
        _vkCmdSetLineRasterizationModeEXT = (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkLineRasterizationModeEXT, void>)loader.GetDeviceProcAddr(device, "vkCmdSetLineRasterizationModeEXT");
        _vkCmdSetLineStippleEnableEXT = (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBool32, void>)loader.GetDeviceProcAddr(device, "vkCmdSetLineStippleEnableEXT");
        _vkCmdSetDepthClipNegativeOneToOneEXT = (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBool32, void>)loader.GetDeviceProcAddr(device, "vkCmdSetDepthClipNegativeOneToOneEXT");
        _vkCmdSetViewportWScalingEnableNV = (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBool32, void>)loader.GetDeviceProcAddr(device, "vkCmdSetViewportWScalingEnableNV");
        _vkCmdSetViewportSwizzleNV = (delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, uint, VkViewportSwizzleNV*, void>)loader.GetDeviceProcAddr(device, "vkCmdSetViewportSwizzleNV");
        _vkCmdSetCoverageToColorEnableNV = (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBool32, void>)loader.GetDeviceProcAddr(device, "vkCmdSetCoverageToColorEnableNV");
        _vkCmdSetCoverageToColorLocationNV = (delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, void>)loader.GetDeviceProcAddr(device, "vkCmdSetCoverageToColorLocationNV");
        _vkCmdSetCoverageModulationModeNV = (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCoverageModulationModeNV, void>)loader.GetDeviceProcAddr(device, "vkCmdSetCoverageModulationModeNV");
        _vkCmdSetCoverageModulationTableEnableNV = (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBool32, void>)loader.GetDeviceProcAddr(device, "vkCmdSetCoverageModulationTableEnableNV");
        _vkCmdSetCoverageModulationTableNV = (delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, float*, void>)loader.GetDeviceProcAddr(device, "vkCmdSetCoverageModulationTableNV");
        _vkCmdSetShadingRateImageEnableNV = (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBool32, void>)loader.GetDeviceProcAddr(device, "vkCmdSetShadingRateImageEnableNV");
        _vkCmdSetRepresentativeFragmentTestEnableNV = (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBool32, void>)loader.GetDeviceProcAddr(device, "vkCmdSetRepresentativeFragmentTestEnableNV");
        _vkCmdSetCoverageReductionModeNV = (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCoverageReductionModeNV, void>)loader.GetDeviceProcAddr(device, "vkCmdSetCoverageReductionModeNV");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkCreateShadersEXT(VkDevice device, uint createInfoCount, VkShaderCreateInfoEXT* pCreateInfos, VkAllocationCallbacks* pAllocator, VkShaderEXT* pShaders)
    {
        return _vkCreateShadersEXT(device, createInfoCount, pCreateInfos, pAllocator, pShaders);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkDestroyShaderEXT(VkDevice device, VkShaderEXT shader, VkAllocationCallbacks* pAllocator)
    {
        _vkDestroyShaderEXT(device, shader, pAllocator);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkGetShaderBinaryDataEXT(VkDevice device, VkShaderEXT shader, nint* pDataSize, void* pData)
    {
        return _vkGetShaderBinaryDataEXT(device, shader, pDataSize, pData);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdBindShadersEXT(VkCommandBuffer commandBuffer, uint stageCount, VkShaderStageFlags* pStages, VkShaderEXT* pShaders)
    {
        _vkCmdBindShadersEXT(commandBuffer, stageCount, pStages, pShaders);
    }

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

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdSetVertexInputEXT(VkCommandBuffer commandBuffer, uint vertexBindingDescriptionCount, VkVertexInputBindingDescription2EXT* pVertexBindingDescriptions, uint vertexAttributeDescriptionCount, VkVertexInputAttributeDescription2EXT* pVertexAttributeDescriptions)
    {
        _vkCmdSetVertexInputEXT(commandBuffer, vertexBindingDescriptionCount, pVertexBindingDescriptions, vertexAttributeDescriptionCount, pVertexAttributeDescriptions);
    }

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

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdSetTessellationDomainOriginEXT(VkCommandBuffer commandBuffer, VkTessellationDomainOrigin domainOrigin)
    {
        _vkCmdSetTessellationDomainOriginEXT(commandBuffer, domainOrigin);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdSetDepthClampEnableEXT(VkCommandBuffer commandBuffer, VkBool32 depthClampEnable)
    {
        _vkCmdSetDepthClampEnableEXT(commandBuffer, depthClampEnable);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdSetPolygonModeEXT(VkCommandBuffer commandBuffer, VkPolygonMode polygonMode)
    {
        _vkCmdSetPolygonModeEXT(commandBuffer, polygonMode);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdSetRasterizationSamplesEXT(VkCommandBuffer commandBuffer, VkSampleCountFlags rasterizationSamples)
    {
        _vkCmdSetRasterizationSamplesEXT(commandBuffer, rasterizationSamples);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdSetSampleMaskEXT(VkCommandBuffer commandBuffer, VkSampleCountFlags samples, VkSampleMask* pSampleMask)
    {
        _vkCmdSetSampleMaskEXT(commandBuffer, samples, pSampleMask);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdSetAlphaToCoverageEnableEXT(VkCommandBuffer commandBuffer, VkBool32 alphaToCoverageEnable)
    {
        _vkCmdSetAlphaToCoverageEnableEXT(commandBuffer, alphaToCoverageEnable);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdSetAlphaToOneEnableEXT(VkCommandBuffer commandBuffer, VkBool32 alphaToOneEnable)
    {
        _vkCmdSetAlphaToOneEnableEXT(commandBuffer, alphaToOneEnable);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdSetLogicOpEnableEXT(VkCommandBuffer commandBuffer, VkBool32 logicOpEnable)
    {
        _vkCmdSetLogicOpEnableEXT(commandBuffer, logicOpEnable);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdSetColorBlendEnableEXT(VkCommandBuffer commandBuffer, uint firstAttachment, uint attachmentCount, VkBool32* pColorBlendEnables)
    {
        _vkCmdSetColorBlendEnableEXT(commandBuffer, firstAttachment, attachmentCount, pColorBlendEnables);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdSetColorBlendEquationEXT(VkCommandBuffer commandBuffer, uint firstAttachment, uint attachmentCount, VkColorBlendEquationEXT* pColorBlendEquations)
    {
        _vkCmdSetColorBlendEquationEXT(commandBuffer, firstAttachment, attachmentCount, pColorBlendEquations);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdSetColorWriteMaskEXT(VkCommandBuffer commandBuffer, uint firstAttachment, uint attachmentCount, VkColorComponentFlags* pColorWriteMasks)
    {
        _vkCmdSetColorWriteMaskEXT(commandBuffer, firstAttachment, attachmentCount, pColorWriteMasks);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdSetRasterizationStreamEXT(VkCommandBuffer commandBuffer, uint rasterizationStream)
    {
        _vkCmdSetRasterizationStreamEXT(commandBuffer, rasterizationStream);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdSetConservativeRasterizationModeEXT(VkCommandBuffer commandBuffer, VkConservativeRasterizationModeEXT conservativeRasterizationMode)
    {
        _vkCmdSetConservativeRasterizationModeEXT(commandBuffer, conservativeRasterizationMode);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdSetExtraPrimitiveOverestimationSizeEXT(VkCommandBuffer commandBuffer, float extraPrimitiveOverestimationSize)
    {
        _vkCmdSetExtraPrimitiveOverestimationSizeEXT(commandBuffer, extraPrimitiveOverestimationSize);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdSetDepthClipEnableEXT(VkCommandBuffer commandBuffer, VkBool32 depthClipEnable)
    {
        _vkCmdSetDepthClipEnableEXT(commandBuffer, depthClipEnable);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdSetSampleLocationsEnableEXT(VkCommandBuffer commandBuffer, VkBool32 sampleLocationsEnable)
    {
        _vkCmdSetSampleLocationsEnableEXT(commandBuffer, sampleLocationsEnable);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdSetColorBlendAdvancedEXT(VkCommandBuffer commandBuffer, uint firstAttachment, uint attachmentCount, VkColorBlendAdvancedEXT* pColorBlendAdvanced)
    {
        _vkCmdSetColorBlendAdvancedEXT(commandBuffer, firstAttachment, attachmentCount, pColorBlendAdvanced);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdSetProvokingVertexModeEXT(VkCommandBuffer commandBuffer, VkProvokingVertexModeEXT provokingVertexMode)
    {
        _vkCmdSetProvokingVertexModeEXT(commandBuffer, provokingVertexMode);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdSetLineRasterizationModeEXT(VkCommandBuffer commandBuffer, VkLineRasterizationModeEXT lineRasterizationMode)
    {
        _vkCmdSetLineRasterizationModeEXT(commandBuffer, lineRasterizationMode);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdSetLineStippleEnableEXT(VkCommandBuffer commandBuffer, VkBool32 stippledLineEnable)
    {
        _vkCmdSetLineStippleEnableEXT(commandBuffer, stippledLineEnable);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdSetDepthClipNegativeOneToOneEXT(VkCommandBuffer commandBuffer, VkBool32 negativeOneToOne)
    {
        _vkCmdSetDepthClipNegativeOneToOneEXT(commandBuffer, negativeOneToOne);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdSetViewportWScalingEnableNV(VkCommandBuffer commandBuffer, VkBool32 viewportWScalingEnable)
    {
        _vkCmdSetViewportWScalingEnableNV(commandBuffer, viewportWScalingEnable);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdSetViewportSwizzleNV(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, VkViewportSwizzleNV* pViewportSwizzles)
    {
        _vkCmdSetViewportSwizzleNV(commandBuffer, firstViewport, viewportCount, pViewportSwizzles);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdSetCoverageToColorEnableNV(VkCommandBuffer commandBuffer, VkBool32 coverageToColorEnable)
    {
        _vkCmdSetCoverageToColorEnableNV(commandBuffer, coverageToColorEnable);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdSetCoverageToColorLocationNV(VkCommandBuffer commandBuffer, uint coverageToColorLocation)
    {
        _vkCmdSetCoverageToColorLocationNV(commandBuffer, coverageToColorLocation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdSetCoverageModulationModeNV(VkCommandBuffer commandBuffer, VkCoverageModulationModeNV coverageModulationMode)
    {
        _vkCmdSetCoverageModulationModeNV(commandBuffer, coverageModulationMode);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdSetCoverageModulationTableEnableNV(VkCommandBuffer commandBuffer, VkBool32 coverageModulationTableEnable)
    {
        _vkCmdSetCoverageModulationTableEnableNV(commandBuffer, coverageModulationTableEnable);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdSetCoverageModulationTableNV(VkCommandBuffer commandBuffer, uint coverageModulationTableCount, float* pCoverageModulationTable)
    {
        _vkCmdSetCoverageModulationTableNV(commandBuffer, coverageModulationTableCount, pCoverageModulationTable);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdSetShadingRateImageEnableNV(VkCommandBuffer commandBuffer, VkBool32 shadingRateImageEnable)
    {
        _vkCmdSetShadingRateImageEnableNV(commandBuffer, shadingRateImageEnable);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdSetRepresentativeFragmentTestEnableNV(VkCommandBuffer commandBuffer, VkBool32 representativeFragmentTestEnable)
    {
        _vkCmdSetRepresentativeFragmentTestEnableNV(commandBuffer, representativeFragmentTestEnable);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdSetCoverageReductionModeNV(VkCommandBuffer commandBuffer, VkCoverageReductionModeNV coverageReductionMode)
    {
        _vkCmdSetCoverageReductionModeNV(commandBuffer, coverageReductionMode);
    }
}