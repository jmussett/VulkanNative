﻿namespace VulkanNative;

public unsafe class VkExtExtendedDynamicState3Extension
{
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkTessellationDomainOrigin, void> vkCmdSetTessellationDomainOriginEXT;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBool32, void> vkCmdSetDepthClampEnableEXT;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPolygonMode, void> vkCmdSetPolygonModeEXT;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkSampleCountFlags, void> vkCmdSetRasterizationSamplesEXT;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkSampleCountFlags, VkSampleMask*, void> vkCmdSetSampleMaskEXT;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBool32, void> vkCmdSetAlphaToCoverageEnableEXT;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBool32, void> vkCmdSetAlphaToOneEnableEXT;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBool32, void> vkCmdSetLogicOpEnableEXT;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, uint, VkBool32*, void> vkCmdSetColorBlendEnableEXT;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, uint, VkColorBlendEquationEXT*, void> vkCmdSetColorBlendEquationEXT;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, uint, VkColorComponentFlags*, void> vkCmdSetColorWriteMaskEXT;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, void> vkCmdSetRasterizationStreamEXT;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkConservativeRasterizationModeEXT, void> vkCmdSetConservativeRasterizationModeEXT;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, float, void> vkCmdSetExtraPrimitiveOverestimationSizeEXT;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBool32, void> vkCmdSetDepthClipEnableEXT;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBool32, void> vkCmdSetSampleLocationsEnableEXT;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, uint, VkColorBlendAdvancedEXT*, void> vkCmdSetColorBlendAdvancedEXT;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkProvokingVertexModeEXT, void> vkCmdSetProvokingVertexModeEXT;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkLineRasterizationModeEXT, void> vkCmdSetLineRasterizationModeEXT;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBool32, void> vkCmdSetLineStippleEnableEXT;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBool32, void> vkCmdSetDepthClipNegativeOneToOneEXT;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBool32, void> vkCmdSetViewportWScalingEnableNV;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, uint, VkViewportSwizzleNV*, void> vkCmdSetViewportSwizzleNV;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBool32, void> vkCmdSetCoverageToColorEnableNV;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, void> vkCmdSetCoverageToColorLocationNV;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCoverageModulationModeNV, void> vkCmdSetCoverageModulationModeNV;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBool32, void> vkCmdSetCoverageModulationTableEnableNV;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, float*, void> vkCmdSetCoverageModulationTableNV;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBool32, void> vkCmdSetShadingRateImageEnableNV;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBool32, void> vkCmdSetRepresentativeFragmentTestEnableNV;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCoverageReductionModeNV, void> vkCmdSetCoverageReductionModeNV;
}