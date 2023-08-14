namespace VulkanNative;

public unsafe class VkNvRayTracingExtension
{
    public delegate* unmanaged[Cdecl]<VkDevice, VkAccelerationStructureCreateInfoNV*, VkAllocationCallbacks*, VkAccelerationStructureNV*, VkResult> vkCreateAccelerationStructureNV;
    public delegate* unmanaged[Cdecl]<VkDevice, VkAccelerationStructureNV, VkAllocationCallbacks*, void> vkDestroyAccelerationStructureNV;
    public delegate* unmanaged[Cdecl]<VkDevice, VkAccelerationStructureMemoryRequirementsInfoNV*, VkMemoryRequirements2*, void> vkGetAccelerationStructureMemoryRequirementsNV;
    public delegate* unmanaged[Cdecl]<VkDevice, uint, VkBindAccelerationStructureMemoryInfoNV*, VkResult> vkBindAccelerationStructureMemoryNV;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkAccelerationStructureInfoNV*, VkBuffer, VkDeviceSize, VkBool32, VkAccelerationStructureNV, VkAccelerationStructureNV, VkBuffer, VkDeviceSize, void> vkCmdBuildAccelerationStructureNV;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkAccelerationStructureNV, VkAccelerationStructureNV, VkCopyAccelerationStructureModeKHR, void> vkCmdCopyAccelerationStructureNV;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBuffer, VkDeviceSize, VkBuffer, VkDeviceSize, VkDeviceSize, VkBuffer, VkDeviceSize, VkDeviceSize, VkBuffer, VkDeviceSize, VkDeviceSize, uint, uint, uint, void> vkCmdTraceRaysNV;
    public delegate* unmanaged[Cdecl]<VkDevice, VkPipelineCache, uint, VkRayTracingPipelineCreateInfoNV*, VkAllocationCallbacks*, VkPipeline*, VkResult> vkCreateRayTracingPipelinesNV;
    public delegate* unmanaged[Cdecl]<VkDevice, VkPipeline, uint, uint, nint, void*, VkResult> vkGetRayTracingShaderGroupHandlesKHR;
    public delegate* unmanaged[Cdecl]<VkDevice, VkAccelerationStructureNV, nint, void*, VkResult> vkGetAccelerationStructureHandleNV;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, VkAccelerationStructureNV*, VkQueryType, VkQueryPool, uint, void> vkCmdWriteAccelerationStructuresPropertiesNV;
    public delegate* unmanaged[Cdecl]<VkDevice, VkPipeline, uint, VkResult> vkCompileDeferredNV;
}