using VulkanNative.Abstractions;
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
    private delegate* unmanaged[Cdecl]<VkDevice, VkPipeline, uint, uint, nuint, void*, VkResult> _vkGetRayTracingShaderGroupHandlesKHR;
    private delegate* unmanaged[Cdecl]<VkDevice, VkAccelerationStructureNV, nuint, void*, VkResult> _vkGetAccelerationStructureHandleNV;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, VkAccelerationStructureNV*, VkQueryType, VkQueryPool, uint, void> _vkCmdWriteAccelerationStructuresPropertiesNV;
    private delegate* unmanaged[Cdecl]<VkDevice, VkPipeline, uint, VkResult> _vkCompileDeferredNV;

    public VkNvRayTracingExtension(VkDevice device, IFunctionLoader loader)
    {
        _vkCreateAccelerationStructureNV = (delegate* unmanaged[Cdecl]<VkDevice, VkAccelerationStructureCreateInfoNV*, VkAllocationCallbacks*, VkAccelerationStructureNV*, VkResult>)loader.GetDeviceProcAddr(device, "vkCreateAccelerationStructureNV");
        _vkDestroyAccelerationStructureNV = (delegate* unmanaged[Cdecl]<VkDevice, VkAccelerationStructureNV, VkAllocationCallbacks*, void>)loader.GetDeviceProcAddr(device, "vkDestroyAccelerationStructureNV");
        _vkGetAccelerationStructureMemoryRequirementsNV = (delegate* unmanaged[Cdecl]<VkDevice, VkAccelerationStructureMemoryRequirementsInfoNV*, VkMemoryRequirements2*, void>)loader.GetDeviceProcAddr(device, "vkGetAccelerationStructureMemoryRequirementsNV");
        _vkBindAccelerationStructureMemoryNV = (delegate* unmanaged[Cdecl]<VkDevice, uint, VkBindAccelerationStructureMemoryInfoNV*, VkResult>)loader.GetDeviceProcAddr(device, "vkBindAccelerationStructureMemoryNV");
        _vkCmdBuildAccelerationStructureNV = (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkAccelerationStructureInfoNV*, VkBuffer, VkDeviceSize, VkBool32, VkAccelerationStructureNV, VkAccelerationStructureNV, VkBuffer, VkDeviceSize, void>)loader.GetDeviceProcAddr(device, "vkCmdBuildAccelerationStructureNV");
        _vkCmdCopyAccelerationStructureNV = (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkAccelerationStructureNV, VkAccelerationStructureNV, VkCopyAccelerationStructureModeKHR, void>)loader.GetDeviceProcAddr(device, "vkCmdCopyAccelerationStructureNV");
        _vkCmdTraceRaysNV = (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBuffer, VkDeviceSize, VkBuffer, VkDeviceSize, VkDeviceSize, VkBuffer, VkDeviceSize, VkDeviceSize, VkBuffer, VkDeviceSize, VkDeviceSize, uint, uint, uint, void>)loader.GetDeviceProcAddr(device, "vkCmdTraceRaysNV");
        _vkCreateRayTracingPipelinesNV = (delegate* unmanaged[Cdecl]<VkDevice, VkPipelineCache, uint, VkRayTracingPipelineCreateInfoNV*, VkAllocationCallbacks*, VkPipeline*, VkResult>)loader.GetDeviceProcAddr(device, "vkCreateRayTracingPipelinesNV");
        _vkGetRayTracingShaderGroupHandlesKHR = (delegate* unmanaged[Cdecl]<VkDevice, VkPipeline, uint, uint, nuint, void*, VkResult>)loader.GetDeviceProcAddr(device, "vkGetRayTracingShaderGroupHandlesKHR");
        _vkGetAccelerationStructureHandleNV = (delegate* unmanaged[Cdecl]<VkDevice, VkAccelerationStructureNV, nuint, void*, VkResult>)loader.GetDeviceProcAddr(device, "vkGetAccelerationStructureHandleNV");
        _vkCmdWriteAccelerationStructuresPropertiesNV = (delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, VkAccelerationStructureNV*, VkQueryType, VkQueryPool, uint, void>)loader.GetDeviceProcAddr(device, "vkCmdWriteAccelerationStructuresPropertiesNV");
        _vkCompileDeferredNV = (delegate* unmanaged[Cdecl]<VkDevice, VkPipeline, uint, VkResult>)loader.GetDeviceProcAddr(device, "vkCompileDeferredNV");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult vkCreateAccelerationStructureNV(VkDevice device, VkAccelerationStructureCreateInfoNV* pCreateInfo, VkAllocationCallbacks* pAllocator, VkAccelerationStructureNV* pAccelerationStructure)
    {
        return _vkCreateAccelerationStructureNV(device, pCreateInfo, pAllocator, pAccelerationStructure);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void vkDestroyAccelerationStructureNV(VkDevice device, VkAccelerationStructureNV accelerationStructure, VkAllocationCallbacks* pAllocator)
    {
        _vkDestroyAccelerationStructureNV(device, accelerationStructure, pAllocator);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void vkGetAccelerationStructureMemoryRequirementsNV(VkDevice device, VkAccelerationStructureMemoryRequirementsInfoNV* pInfo, VkMemoryRequirements2* pMemoryRequirements)
    {
        _vkGetAccelerationStructureMemoryRequirementsNV(device, pInfo, pMemoryRequirements);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult vkBindAccelerationStructureMemoryNV(VkDevice device, uint bindInfoCount, VkBindAccelerationStructureMemoryInfoNV* pBindInfos)
    {
        return _vkBindAccelerationStructureMemoryNV(device, bindInfoCount, pBindInfos);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void vkCmdBuildAccelerationStructureNV(VkCommandBuffer commandBuffer, VkAccelerationStructureInfoNV* pInfo, VkBuffer instanceData, VkDeviceSize instanceOffset, VkBool32 update, VkAccelerationStructureNV dst, VkAccelerationStructureNV src, VkBuffer scratch, VkDeviceSize scratchOffset)
    {
        _vkCmdBuildAccelerationStructureNV(commandBuffer, pInfo, instanceData, instanceOffset, update, dst, src, scratch, scratchOffset);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void vkCmdCopyAccelerationStructureNV(VkCommandBuffer commandBuffer, VkAccelerationStructureNV dst, VkAccelerationStructureNV src, VkCopyAccelerationStructureModeKHR mode)
    {
        _vkCmdCopyAccelerationStructureNV(commandBuffer, dst, src, mode);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void vkCmdTraceRaysNV(VkCommandBuffer commandBuffer, VkBuffer raygenShaderBindingTableBuffer, VkDeviceSize raygenShaderBindingOffset, VkBuffer missShaderBindingTableBuffer, VkDeviceSize missShaderBindingOffset, VkDeviceSize missShaderBindingStride, VkBuffer hitShaderBindingTableBuffer, VkDeviceSize hitShaderBindingOffset, VkDeviceSize hitShaderBindingStride, VkBuffer callableShaderBindingTableBuffer, VkDeviceSize callableShaderBindingOffset, VkDeviceSize callableShaderBindingStride, uint width, uint height, uint depth)
    {
        _vkCmdTraceRaysNV(commandBuffer, raygenShaderBindingTableBuffer, raygenShaderBindingOffset, missShaderBindingTableBuffer, missShaderBindingOffset, missShaderBindingStride, hitShaderBindingTableBuffer, hitShaderBindingOffset, hitShaderBindingStride, callableShaderBindingTableBuffer, callableShaderBindingOffset, callableShaderBindingStride, width, height, depth);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult vkCreateRayTracingPipelinesNV(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkRayTracingPipelineCreateInfoNV* pCreateInfos, VkAllocationCallbacks* pAllocator, VkPipeline* pPipelines)
    {
        return _vkCreateRayTracingPipelinesNV(device, pipelineCache, createInfoCount, pCreateInfos, pAllocator, pPipelines);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult vkGetRayTracingShaderGroupHandlesKHR(VkDevice device, VkPipeline pipeline, uint firstGroup, uint groupCount, nuint dataSize, void* pData)
    {
        return _vkGetRayTracingShaderGroupHandlesKHR(device, pipeline, firstGroup, groupCount, dataSize, pData);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult vkGetAccelerationStructureHandleNV(VkDevice device, VkAccelerationStructureNV accelerationStructure, nuint dataSize, void* pData)
    {
        return _vkGetAccelerationStructureHandleNV(device, accelerationStructure, dataSize, pData);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void vkCmdWriteAccelerationStructuresPropertiesNV(VkCommandBuffer commandBuffer, uint accelerationStructureCount, VkAccelerationStructureNV* pAccelerationStructures, VkQueryType queryType, VkQueryPool queryPool, uint firstQuery)
    {
        _vkCmdWriteAccelerationStructuresPropertiesNV(commandBuffer, accelerationStructureCount, pAccelerationStructures, queryType, queryPool, firstQuery);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult vkCompileDeferredNV(VkDevice device, VkPipeline pipeline, uint shader)
    {
        return _vkCompileDeferredNV(device, pipeline, shader);
    }
}