using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkExtOpacityMicromapExtension
{
    private delegate* unmanaged[Cdecl]<VkDevice, VkMicromapCreateInfoEXT*, VkAllocationCallbacks*, VkMicromapEXT*, VkResult> _vkCreateMicromapEXT;
    private delegate* unmanaged[Cdecl]<VkDevice, VkMicromapEXT, VkAllocationCallbacks*, void> _vkDestroyMicromapEXT;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, VkMicromapBuildInfoEXT*, void> _vkCmdBuildMicromapsEXT;
    private delegate* unmanaged[Cdecl]<VkDevice, VkDeferredOperationKHR, uint, VkMicromapBuildInfoEXT*, VkResult> _vkBuildMicromapsEXT;
    private delegate* unmanaged[Cdecl]<VkDevice, VkDeferredOperationKHR, VkCopyMicromapInfoEXT*, VkResult> _vkCopyMicromapEXT;
    private delegate* unmanaged[Cdecl]<VkDevice, VkDeferredOperationKHR, VkCopyMicromapToMemoryInfoEXT*, VkResult> _vkCopyMicromapToMemoryEXT;
    private delegate* unmanaged[Cdecl]<VkDevice, VkDeferredOperationKHR, VkCopyMemoryToMicromapInfoEXT*, VkResult> _vkCopyMemoryToMicromapEXT;
    private delegate* unmanaged[Cdecl]<VkDevice, uint, VkMicromapEXT*, VkQueryType, nint, void*, nint, VkResult> _vkWriteMicromapsPropertiesEXT;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCopyMicromapInfoEXT*, void> _vkCmdCopyMicromapEXT;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCopyMicromapToMemoryInfoEXT*, void> _vkCmdCopyMicromapToMemoryEXT;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCopyMemoryToMicromapInfoEXT*, void> _vkCmdCopyMemoryToMicromapEXT;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, VkMicromapEXT*, VkQueryType, VkQueryPool, uint, void> _vkCmdWriteMicromapsPropertiesEXT;
    private delegate* unmanaged[Cdecl]<VkDevice, VkMicromapVersionInfoEXT*, VkAccelerationStructureCompatibilityKHR*, void> _vkGetDeviceMicromapCompatibilityEXT;
    private delegate* unmanaged[Cdecl]<VkDevice, VkAccelerationStructureBuildTypeKHR, VkMicromapBuildInfoEXT*, VkMicromapBuildSizesInfoEXT*, void> _vkGetMicromapBuildSizesEXT;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkCreateMicromapEXT(VkDevice device, VkMicromapCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkMicromapEXT* pMicromap)
    {
        return _vkCreateMicromapEXT(device, pCreateInfo, pAllocator, pMicromap);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkDestroyMicromapEXT(VkDevice device, VkMicromapEXT micromap, VkAllocationCallbacks* pAllocator)
    {
        _vkDestroyMicromapEXT(device, micromap, pAllocator);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdBuildMicromapsEXT(VkCommandBuffer commandBuffer, uint infoCount, VkMicromapBuildInfoEXT* pInfos)
    {
        _vkCmdBuildMicromapsEXT(commandBuffer, infoCount, pInfos);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkBuildMicromapsEXT(VkDevice device, VkDeferredOperationKHR deferredOperation, uint infoCount, VkMicromapBuildInfoEXT* pInfos)
    {
        return _vkBuildMicromapsEXT(device, deferredOperation, infoCount, pInfos);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkCopyMicromapEXT(VkDevice device, VkDeferredOperationKHR deferredOperation, VkCopyMicromapInfoEXT* pInfo)
    {
        return _vkCopyMicromapEXT(device, deferredOperation, pInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkCopyMicromapToMemoryEXT(VkDevice device, VkDeferredOperationKHR deferredOperation, VkCopyMicromapToMemoryInfoEXT* pInfo)
    {
        return _vkCopyMicromapToMemoryEXT(device, deferredOperation, pInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkCopyMemoryToMicromapEXT(VkDevice device, VkDeferredOperationKHR deferredOperation, VkCopyMemoryToMicromapInfoEXT* pInfo)
    {
        return _vkCopyMemoryToMicromapEXT(device, deferredOperation, pInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkWriteMicromapsPropertiesEXT(VkDevice device, uint micromapCount, VkMicromapEXT* pMicromaps, VkQueryType queryType, nint dataSize, void* pData, nint stride)
    {
        return _vkWriteMicromapsPropertiesEXT(device, micromapCount, pMicromaps, queryType, dataSize, pData, stride);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdCopyMicromapEXT(VkCommandBuffer commandBuffer, VkCopyMicromapInfoEXT* pInfo)
    {
        _vkCmdCopyMicromapEXT(commandBuffer, pInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdCopyMicromapToMemoryEXT(VkCommandBuffer commandBuffer, VkCopyMicromapToMemoryInfoEXT* pInfo)
    {
        _vkCmdCopyMicromapToMemoryEXT(commandBuffer, pInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdCopyMemoryToMicromapEXT(VkCommandBuffer commandBuffer, VkCopyMemoryToMicromapInfoEXT* pInfo)
    {
        _vkCmdCopyMemoryToMicromapEXT(commandBuffer, pInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdWriteMicromapsPropertiesEXT(VkCommandBuffer commandBuffer, uint micromapCount, VkMicromapEXT* pMicromaps, VkQueryType queryType, VkQueryPool queryPool, uint firstQuery)
    {
        _vkCmdWriteMicromapsPropertiesEXT(commandBuffer, micromapCount, pMicromaps, queryType, queryPool, firstQuery);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkGetDeviceMicromapCompatibilityEXT(VkDevice device, VkMicromapVersionInfoEXT* pVersionInfo, VkAccelerationStructureCompatibilityKHR* pCompatibility)
    {
        _vkGetDeviceMicromapCompatibilityEXT(device, pVersionInfo, pCompatibility);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkGetMicromapBuildSizesEXT(VkDevice device, VkAccelerationStructureBuildTypeKHR buildType, VkMicromapBuildInfoEXT* pBuildInfo, VkMicromapBuildSizesInfoEXT* pSizeInfo)
    {
        _vkGetMicromapBuildSizesEXT(device, buildType, pBuildInfo, pSizeInfo);
    }
}