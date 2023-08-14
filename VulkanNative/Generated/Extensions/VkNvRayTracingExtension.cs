using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkNvRayTracingExtension
{
    private delegate* unmanaged[Cdecl]<VkDevice, VkAccelerationStructureCreateInfoNV*, VkAllocationCallbacks*, VkAccelerationStructureNV*, VkResult> _vkCreateAccelerationStructureNV;
    private delegate* unmanaged[Cdecl]<VkDevice, VkAccelerationStructureNV, VkAllocationCallbacks*, void> _vkDestroyAccelerationStructureNV;
    private delegate* unmanaged[Cdecl]<VkDevice, VkAccelerationStructureMemoryRequirementsInfoNV*, VkMemoryRequirements2*, void> _vkGetAccelerationStructureMemoryRequirementsNV;
    private delegate* unmanaged[Cdecl]<VkDevice, uint, VkBindAccelerationStructureMemoryInfoNV*, VkResult> _vkBindAccelerationStructureMemoryNV;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkAccelerationStructureInfoNV*, VkBuffer, VkDeviceSize, VkBool32, VkAccelerationStructureNV, VkAccelerationStructureNV, VkBuffer, VkDeviceSize, void> _vkCmdBuildAccelerationStructureNV;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkAccelerationStructureNV, VkAccelerationStructureNV, VkCopyAccelerationStructureModeKHR, void> _vkCmdCopyAccelerationStructureNV;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBuffer, VkDeviceSize, VkBuffer, VkDeviceSize, VkDeviceSize, VkBuffer, VkDeviceSize, VkDeviceSize, VkBuffer, VkDeviceSize, VkDeviceSize, uint, uint, uint, void> _vkCmdTraceRaysNV;
    private delegate* unmanaged[Cdecl]<VkDevice, VkPipelineCache, uint, VkRayTracingPipelineCreateInfoNV*, VkAllocationCallbacks*, VkPipeline*, VkResult> _vkCreateRayTracingPipelinesNV;
    private delegate* unmanaged[Cdecl]<VkDevice, VkPipeline, uint, uint, nint, void*, VkResult> _vkGetRayTracingShaderGroupHandlesKHR;
    private delegate* unmanaged[Cdecl]<VkDevice, VkAccelerationStructureNV, nint, void*, VkResult> _vkGetAccelerationStructureHandleNV;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, VkAccelerationStructureNV*, VkQueryType, VkQueryPool, uint, void> _vkCmdWriteAccelerationStructuresPropertiesNV;
    private delegate* unmanaged[Cdecl]<VkDevice, VkPipeline, uint, VkResult> _vkCompileDeferredNV;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkCreateAccelerationStructureNV(VkDevice device, VkAccelerationStructureCreateInfoNV* pCreateInfo, VkAllocationCallbacks* pAllocator, VkAccelerationStructureNV* pAccelerationStructure)
    {
        return _vkCreateAccelerationStructureNV(device, pCreateInfo, pAllocator, pAccelerationStructure);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkDestroyAccelerationStructureNV(VkDevice device, VkAccelerationStructureNV accelerationStructure, VkAllocationCallbacks* pAllocator)
    {
        _vkDestroyAccelerationStructureNV(device, accelerationStructure, pAllocator);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkGetAccelerationStructureMemoryRequirementsNV(VkDevice device, VkAccelerationStructureMemoryRequirementsInfoNV* pInfo, VkMemoryRequirements2* pMemoryRequirements)
    {
        _vkGetAccelerationStructureMemoryRequirementsNV(device, pInfo, pMemoryRequirements);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkBindAccelerationStructureMemoryNV(VkDevice device, uint bindInfoCount, VkBindAccelerationStructureMemoryInfoNV* pBindInfos)
    {
        return _vkBindAccelerationStructureMemoryNV(device, bindInfoCount, pBindInfos);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdBuildAccelerationStructureNV(VkCommandBuffer commandBuffer, VkAccelerationStructureInfoNV* pInfo, VkBuffer instanceData, VkDeviceSize instanceOffset, VkBool32 update, VkAccelerationStructureNV dst, VkAccelerationStructureNV src, VkBuffer scratch, VkDeviceSize scratchOffset)
    {
        _vkCmdBuildAccelerationStructureNV(commandBuffer, pInfo, instanceData, instanceOffset, update, dst, src, scratch, scratchOffset);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdCopyAccelerationStructureNV(VkCommandBuffer commandBuffer, VkAccelerationStructureNV dst, VkAccelerationStructureNV src, VkCopyAccelerationStructureModeKHR mode)
    {
        _vkCmdCopyAccelerationStructureNV(commandBuffer, dst, src, mode);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdTraceRaysNV(VkCommandBuffer commandBuffer, VkBuffer raygenShaderBindingTableBuffer, VkDeviceSize raygenShaderBindingOffset, VkBuffer missShaderBindingTableBuffer, VkDeviceSize missShaderBindingOffset, VkDeviceSize missShaderBindingStride, VkBuffer hitShaderBindingTableBuffer, VkDeviceSize hitShaderBindingOffset, VkDeviceSize hitShaderBindingStride, VkBuffer callableShaderBindingTableBuffer, VkDeviceSize callableShaderBindingOffset, VkDeviceSize callableShaderBindingStride, uint width, uint height, uint depth)
    {
        _vkCmdTraceRaysNV(commandBuffer, raygenShaderBindingTableBuffer, raygenShaderBindingOffset, missShaderBindingTableBuffer, missShaderBindingOffset, missShaderBindingStride, hitShaderBindingTableBuffer, hitShaderBindingOffset, hitShaderBindingStride, callableShaderBindingTableBuffer, callableShaderBindingOffset, callableShaderBindingStride, width, height, depth);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkCreateRayTracingPipelinesNV(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkRayTracingPipelineCreateInfoNV* pCreateInfos, VkAllocationCallbacks* pAllocator, VkPipeline* pPipelines)
    {
        return _vkCreateRayTracingPipelinesNV(device, pipelineCache, createInfoCount, pCreateInfos, pAllocator, pPipelines);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkGetRayTracingShaderGroupHandlesKHR(VkDevice device, VkPipeline pipeline, uint firstGroup, uint groupCount, nint dataSize, void* pData)
    {
        return _vkGetRayTracingShaderGroupHandlesKHR(device, pipeline, firstGroup, groupCount, dataSize, pData);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkGetAccelerationStructureHandleNV(VkDevice device, VkAccelerationStructureNV accelerationStructure, nint dataSize, void* pData)
    {
        return _vkGetAccelerationStructureHandleNV(device, accelerationStructure, dataSize, pData);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdWriteAccelerationStructuresPropertiesNV(VkCommandBuffer commandBuffer, uint accelerationStructureCount, VkAccelerationStructureNV* pAccelerationStructures, VkQueryType queryType, VkQueryPool queryPool, uint firstQuery)
    {
        _vkCmdWriteAccelerationStructuresPropertiesNV(commandBuffer, accelerationStructureCount, pAccelerationStructures, queryType, queryPool, firstQuery);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkCompileDeferredNV(VkDevice device, VkPipeline pipeline, uint shader)
    {
        return _vkCompileDeferredNV(device, pipeline, shader);
    }
}