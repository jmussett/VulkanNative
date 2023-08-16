using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkKhrRayTracingPipelineExtension
{
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkStridedDeviceAddressRegionKHR*, VkStridedDeviceAddressRegionKHR*, VkStridedDeviceAddressRegionKHR*, VkStridedDeviceAddressRegionKHR*, uint, uint, uint, void> _vkCmdTraceRaysKHR;
    private delegate* unmanaged[Cdecl]<VkDevice, VkDeferredOperationKHR, VkPipelineCache, uint, VkRayTracingPipelineCreateInfoKHR*, VkAllocationCallbacks*, VkPipeline*, VkResult> _vkCreateRayTracingPipelinesKHR;
    private delegate* unmanaged[Cdecl]<VkDevice, VkPipeline, uint, uint, nint, void*, VkResult> _vkGetRayTracingShaderGroupHandlesKHR;
    private delegate* unmanaged[Cdecl]<VkDevice, VkPipeline, uint, uint, nint, void*, VkResult> _vkGetRayTracingCaptureReplayShaderGroupHandlesKHR;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkStridedDeviceAddressRegionKHR*, VkStridedDeviceAddressRegionKHR*, VkStridedDeviceAddressRegionKHR*, VkStridedDeviceAddressRegionKHR*, VkDeviceAddress, void> _vkCmdTraceRaysIndirectKHR;
    private delegate* unmanaged[Cdecl]<VkDevice, VkPipeline, uint, VkShaderGroupShaderKHR, VkDeviceSize> _vkGetRayTracingShaderGroupStackSizeKHR;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, void> _vkCmdSetRayTracingPipelineStackSizeKHR;

    public VkKhrRayTracingPipelineExtension(VkDevice device, IFunctionLoader loader)
    {
        _vkCmdTraceRaysKHR = (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkStridedDeviceAddressRegionKHR*, VkStridedDeviceAddressRegionKHR*, VkStridedDeviceAddressRegionKHR*, VkStridedDeviceAddressRegionKHR*, uint, uint, uint, void>)loader.GetDeviceProcAddr(device, "vkCmdTraceRaysKHR");
        _vkCreateRayTracingPipelinesKHR = (delegate* unmanaged[Cdecl]<VkDevice, VkDeferredOperationKHR, VkPipelineCache, uint, VkRayTracingPipelineCreateInfoKHR*, VkAllocationCallbacks*, VkPipeline*, VkResult>)loader.GetDeviceProcAddr(device, "vkCreateRayTracingPipelinesKHR");
        _vkGetRayTracingShaderGroupHandlesKHR = (delegate* unmanaged[Cdecl]<VkDevice, VkPipeline, uint, uint, nint, void*, VkResult>)loader.GetDeviceProcAddr(device, "vkGetRayTracingShaderGroupHandlesKHR");
        _vkGetRayTracingCaptureReplayShaderGroupHandlesKHR = (delegate* unmanaged[Cdecl]<VkDevice, VkPipeline, uint, uint, nint, void*, VkResult>)loader.GetDeviceProcAddr(device, "vkGetRayTracingCaptureReplayShaderGroupHandlesKHR");
        _vkCmdTraceRaysIndirectKHR = (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkStridedDeviceAddressRegionKHR*, VkStridedDeviceAddressRegionKHR*, VkStridedDeviceAddressRegionKHR*, VkStridedDeviceAddressRegionKHR*, VkDeviceAddress, void>)loader.GetDeviceProcAddr(device, "vkCmdTraceRaysIndirectKHR");
        _vkGetRayTracingShaderGroupStackSizeKHR = (delegate* unmanaged[Cdecl]<VkDevice, VkPipeline, uint, VkShaderGroupShaderKHR, VkDeviceSize>)loader.GetDeviceProcAddr(device, "vkGetRayTracingShaderGroupStackSizeKHR");
        _vkCmdSetRayTracingPipelineStackSizeKHR = (delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, void>)loader.GetDeviceProcAddr(device, "vkCmdSetRayTracingPipelineStackSizeKHR");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, uint width, uint height, uint depth)
    {
        _vkCmdTraceRaysKHR(commandBuffer, pRaygenShaderBindingTable, pMissShaderBindingTable, pHitShaderBindingTable, pCallableShaderBindingTable, width, height, depth);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkCreateRayTracingPipelinesKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, VkPipelineCache pipelineCache, uint createInfoCount, VkRayTracingPipelineCreateInfoKHR* pCreateInfos, VkAllocationCallbacks* pAllocator, VkPipeline* pPipelines)
    {
        return _vkCreateRayTracingPipelinesKHR(device, deferredOperation, pipelineCache, createInfoCount, pCreateInfos, pAllocator, pPipelines);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkGetRayTracingShaderGroupHandlesKHR(VkDevice device, VkPipeline pipeline, uint firstGroup, uint groupCount, nint dataSize, void* pData)
    {
        return _vkGetRayTracingShaderGroupHandlesKHR(device, pipeline, firstGroup, groupCount, dataSize, pData);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkGetRayTracingCaptureReplayShaderGroupHandlesKHR(VkDevice device, VkPipeline pipeline, uint firstGroup, uint groupCount, nint dataSize, void* pData)
    {
        return _vkGetRayTracingCaptureReplayShaderGroupHandlesKHR(device, pipeline, firstGroup, groupCount, dataSize, pData);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, VkDeviceAddress indirectDeviceAddress)
    {
        _vkCmdTraceRaysIndirectKHR(commandBuffer, pRaygenShaderBindingTable, pMissShaderBindingTable, pHitShaderBindingTable, pCallableShaderBindingTable, indirectDeviceAddress);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkDeviceSize VkGetRayTracingShaderGroupStackSizeKHR(VkDevice device, VkPipeline pipeline, uint group, VkShaderGroupShaderKHR groupShader)
    {
        return _vkGetRayTracingShaderGroupStackSizeKHR(device, pipeline, group, groupShader);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdSetRayTracingPipelineStackSizeKHR(VkCommandBuffer commandBuffer, uint pipelineStackSize)
    {
        _vkCmdSetRayTracingPipelineStackSizeKHR(commandBuffer, pipelineStackSize);
    }
}