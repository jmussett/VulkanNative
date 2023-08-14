namespace VulkanNative;

public unsafe class VkExtOpacityMicromapExtension
{
    public delegate* unmanaged[Cdecl]<VkDevice, VkMicromapCreateInfoEXT*, VkAllocationCallbacks*, VkMicromapEXT*, VkResult> vkCreateMicromapEXT;
    public delegate* unmanaged[Cdecl]<VkDevice, VkMicromapEXT, VkAllocationCallbacks*, void> vkDestroyMicromapEXT;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, VkMicromapBuildInfoEXT*, void> vkCmdBuildMicromapsEXT;
    public delegate* unmanaged[Cdecl]<VkDevice, VkDeferredOperationKHR, uint, VkMicromapBuildInfoEXT*, VkResult> vkBuildMicromapsEXT;
    public delegate* unmanaged[Cdecl]<VkDevice, VkDeferredOperationKHR, VkCopyMicromapInfoEXT*, VkResult> vkCopyMicromapEXT;
    public delegate* unmanaged[Cdecl]<VkDevice, VkDeferredOperationKHR, VkCopyMicromapToMemoryInfoEXT*, VkResult> vkCopyMicromapToMemoryEXT;
    public delegate* unmanaged[Cdecl]<VkDevice, VkDeferredOperationKHR, VkCopyMemoryToMicromapInfoEXT*, VkResult> vkCopyMemoryToMicromapEXT;
    public delegate* unmanaged[Cdecl]<VkDevice, uint, VkMicromapEXT*, VkQueryType, nint, void*, nint, VkResult> vkWriteMicromapsPropertiesEXT;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCopyMicromapInfoEXT*, void> vkCmdCopyMicromapEXT;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCopyMicromapToMemoryInfoEXT*, void> vkCmdCopyMicromapToMemoryEXT;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCopyMemoryToMicromapInfoEXT*, void> vkCmdCopyMemoryToMicromapEXT;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, VkMicromapEXT*, VkQueryType, VkQueryPool, uint, void> vkCmdWriteMicromapsPropertiesEXT;
    public delegate* unmanaged[Cdecl]<VkDevice, VkMicromapVersionInfoEXT*, VkAccelerationStructureCompatibilityKHR*, void> vkGetDeviceMicromapCompatibilityEXT;
    public delegate* unmanaged[Cdecl]<VkDevice, VkAccelerationStructureBuildTypeKHR, VkMicromapBuildInfoEXT*, VkMicromapBuildSizesInfoEXT*, void> vkGetMicromapBuildSizesEXT;
}