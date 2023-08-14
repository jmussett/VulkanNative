namespace VulkanNative;

public unsafe class VkKhrRayTracingPipelineExtension
{
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkStridedDeviceAddressRegionKHR*, VkStridedDeviceAddressRegionKHR*, VkStridedDeviceAddressRegionKHR*, VkStridedDeviceAddressRegionKHR*, uint, uint, uint, void> vkCmdTraceRaysKHR;
    public delegate* unmanaged[Cdecl]<VkDevice, VkDeferredOperationKHR, VkPipelineCache, uint, VkRayTracingPipelineCreateInfoKHR*, VkAllocationCallbacks*, VkPipeline*, VkResult> vkCreateRayTracingPipelinesKHR;
    public delegate* unmanaged[Cdecl]<VkDevice, VkPipeline, uint, uint, nint, void*, VkResult> vkGetRayTracingShaderGroupHandlesKHR;
    public delegate* unmanaged[Cdecl]<VkDevice, VkPipeline, uint, uint, nint, void*, VkResult> vkGetRayTracingCaptureReplayShaderGroupHandlesKHR;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkStridedDeviceAddressRegionKHR*, VkStridedDeviceAddressRegionKHR*, VkStridedDeviceAddressRegionKHR*, VkStridedDeviceAddressRegionKHR*, VkDeviceAddress, void> vkCmdTraceRaysIndirectKHR;
    public delegate* unmanaged[Cdecl]<VkDevice, VkPipeline, uint, VkShaderGroupShaderKHR, VkDeviceSize> vkGetRayTracingShaderGroupStackSizeKHR;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, void> vkCmdSetRayTracingPipelineStackSizeKHR;
}