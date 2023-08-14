namespace VulkanNative;

public unsafe class VkKhrAccelerationStructureExtension
{
    public delegate* unmanaged[Cdecl]<VkDevice, VkAccelerationStructureCreateInfoKHR*, VkAllocationCallbacks*, VkAccelerationStructureKHR*, VkResult> vkCreateAccelerationStructureKHR;
    public delegate* unmanaged[Cdecl]<VkDevice, VkAccelerationStructureKHR, VkAllocationCallbacks*, void> vkDestroyAccelerationStructureKHR;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, VkAccelerationStructureBuildGeometryInfoKHR*, VkAccelerationStructureBuildRangeInfoKHR**, void> vkCmdBuildAccelerationStructuresKHR;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, VkAccelerationStructureBuildGeometryInfoKHR*, VkDeviceAddress*, uint*, uint**, void> vkCmdBuildAccelerationStructuresIndirectKHR;
    public delegate* unmanaged[Cdecl]<VkDevice, VkDeferredOperationKHR, uint, VkAccelerationStructureBuildGeometryInfoKHR*, VkAccelerationStructureBuildRangeInfoKHR**, VkResult> vkBuildAccelerationStructuresKHR;
    public delegate* unmanaged[Cdecl]<VkDevice, VkDeferredOperationKHR, VkCopyAccelerationStructureInfoKHR*, VkResult> vkCopyAccelerationStructureKHR;
    public delegate* unmanaged[Cdecl]<VkDevice, VkDeferredOperationKHR, VkCopyAccelerationStructureToMemoryInfoKHR*, VkResult> vkCopyAccelerationStructureToMemoryKHR;
    public delegate* unmanaged[Cdecl]<VkDevice, VkDeferredOperationKHR, VkCopyMemoryToAccelerationStructureInfoKHR*, VkResult> vkCopyMemoryToAccelerationStructureKHR;
    public delegate* unmanaged[Cdecl]<VkDevice, uint, VkAccelerationStructureKHR*, VkQueryType, nint, void*, nint, VkResult> vkWriteAccelerationStructuresPropertiesKHR;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCopyAccelerationStructureInfoKHR*, void> vkCmdCopyAccelerationStructureKHR;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCopyAccelerationStructureToMemoryInfoKHR*, void> vkCmdCopyAccelerationStructureToMemoryKHR;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCopyMemoryToAccelerationStructureInfoKHR*, void> vkCmdCopyMemoryToAccelerationStructureKHR;
    public delegate* unmanaged[Cdecl]<VkDevice, VkAccelerationStructureDeviceAddressInfoKHR*, VkDeviceAddress> vkGetAccelerationStructureDeviceAddressKHR;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, VkAccelerationStructureKHR*, VkQueryType, VkQueryPool, uint, void> vkCmdWriteAccelerationStructuresPropertiesKHR;
    public delegate* unmanaged[Cdecl]<VkDevice, VkAccelerationStructureVersionInfoKHR*, VkAccelerationStructureCompatibilityKHR*, void> vkGetDeviceAccelerationStructureCompatibilityKHR;
    public delegate* unmanaged[Cdecl]<VkDevice, VkAccelerationStructureBuildTypeKHR, VkAccelerationStructureBuildGeometryInfoKHR*, uint*, VkAccelerationStructureBuildSizesInfoKHR*, void> vkGetAccelerationStructureBuildSizesKHR;
}