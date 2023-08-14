using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkExtExtendedDynamicState3Extension
{
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