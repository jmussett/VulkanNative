﻿using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkNvDeviceGeneratedCommandsExtension
{
    private delegate* unmanaged[Cdecl]<VkDevice, VkGeneratedCommandsMemoryRequirementsInfoNV*, VkMemoryRequirements2*, void> _vkGetGeneratedCommandsMemoryRequirementsNV;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkGeneratedCommandsInfoNV*, void> _vkCmdPreprocessGeneratedCommandsNV;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBool32, VkGeneratedCommandsInfoNV*, void> _vkCmdExecuteGeneratedCommandsNV;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPipelineBindPoint, VkPipeline, uint, void> _vkCmdBindPipelineShaderGroupNV;
    private delegate* unmanaged[Cdecl]<VkDevice, VkIndirectCommandsLayoutCreateInfoNV*, VkAllocationCallbacks*, VkIndirectCommandsLayoutNV*, VkResult> _vkCreateIndirectCommandsLayoutNV;
    private delegate* unmanaged[Cdecl]<VkDevice, VkIndirectCommandsLayoutNV, VkAllocationCallbacks*, void> _vkDestroyIndirectCommandsLayoutNV;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkGetGeneratedCommandsMemoryRequirementsNV(VkDevice device, VkGeneratedCommandsMemoryRequirementsInfoNV* pInfo, VkMemoryRequirements2* pMemoryRequirements)
    {
        _vkGetGeneratedCommandsMemoryRequirementsNV(device, pInfo, pMemoryRequirements);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdPreprocessGeneratedCommandsNV(VkCommandBuffer commandBuffer, VkGeneratedCommandsInfoNV* pGeneratedCommandsInfo)
    {
        _vkCmdPreprocessGeneratedCommandsNV(commandBuffer, pGeneratedCommandsInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdExecuteGeneratedCommandsNV(VkCommandBuffer commandBuffer, VkBool32 isPreprocessed, VkGeneratedCommandsInfoNV* pGeneratedCommandsInfo)
    {
        _vkCmdExecuteGeneratedCommandsNV(commandBuffer, isPreprocessed, pGeneratedCommandsInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdBindPipelineShaderGroupNV(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipeline pipeline, uint groupIndex)
    {
        _vkCmdBindPipelineShaderGroupNV(commandBuffer, pipelineBindPoint, pipeline, groupIndex);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkCreateIndirectCommandsLayoutNV(VkDevice device, VkIndirectCommandsLayoutCreateInfoNV* pCreateInfo, VkAllocationCallbacks* pAllocator, VkIndirectCommandsLayoutNV* pIndirectCommandsLayout)
    {
        return _vkCreateIndirectCommandsLayoutNV(device, pCreateInfo, pAllocator, pIndirectCommandsLayout);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkDestroyIndirectCommandsLayoutNV(VkDevice device, VkIndirectCommandsLayoutNV indirectCommandsLayout, VkAllocationCallbacks* pAllocator)
    {
        _vkDestroyIndirectCommandsLayoutNV(device, indirectCommandsLayout, pAllocator);
    }
}