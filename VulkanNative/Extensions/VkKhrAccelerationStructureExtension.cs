﻿using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkKhrAccelerationStructureExtension
{
    private delegate* unmanaged[Cdecl]<VkDevice, VkAccelerationStructureCreateInfoKHR*, VkAllocationCallbacks*, VkAccelerationStructureKHR*, VkResult> _vkCreateAccelerationStructureKHR;
    private delegate* unmanaged[Cdecl]<VkDevice, VkAccelerationStructureKHR, VkAllocationCallbacks*, void> _vkDestroyAccelerationStructureKHR;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, VkAccelerationStructureBuildGeometryInfoKHR*, VkAccelerationStructureBuildRangeInfoKHR**, void> _vkCmdBuildAccelerationStructuresKHR;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, VkAccelerationStructureBuildGeometryInfoKHR*, VkDeviceAddress*, uint*, uint**, void> _vkCmdBuildAccelerationStructuresIndirectKHR;
    private delegate* unmanaged[Cdecl]<VkDevice, VkDeferredOperationKHR, uint, VkAccelerationStructureBuildGeometryInfoKHR*, VkAccelerationStructureBuildRangeInfoKHR**, VkResult> _vkBuildAccelerationStructuresKHR;
    private delegate* unmanaged[Cdecl]<VkDevice, VkDeferredOperationKHR, VkCopyAccelerationStructureInfoKHR*, VkResult> _vkCopyAccelerationStructureKHR;
    private delegate* unmanaged[Cdecl]<VkDevice, VkDeferredOperationKHR, VkCopyAccelerationStructureToMemoryInfoKHR*, VkResult> _vkCopyAccelerationStructureToMemoryKHR;
    private delegate* unmanaged[Cdecl]<VkDevice, VkDeferredOperationKHR, VkCopyMemoryToAccelerationStructureInfoKHR*, VkResult> _vkCopyMemoryToAccelerationStructureKHR;
    private delegate* unmanaged[Cdecl]<VkDevice, uint, VkAccelerationStructureKHR*, VkQueryType, nint, void*, nint, VkResult> _vkWriteAccelerationStructuresPropertiesKHR;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCopyAccelerationStructureInfoKHR*, void> _vkCmdCopyAccelerationStructureKHR;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCopyAccelerationStructureToMemoryInfoKHR*, void> _vkCmdCopyAccelerationStructureToMemoryKHR;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCopyMemoryToAccelerationStructureInfoKHR*, void> _vkCmdCopyMemoryToAccelerationStructureKHR;
    private delegate* unmanaged[Cdecl]<VkDevice, VkAccelerationStructureDeviceAddressInfoKHR*, VkDeviceAddress> _vkGetAccelerationStructureDeviceAddressKHR;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, VkAccelerationStructureKHR*, VkQueryType, VkQueryPool, uint, void> _vkCmdWriteAccelerationStructuresPropertiesKHR;
    private delegate* unmanaged[Cdecl]<VkDevice, VkAccelerationStructureVersionInfoKHR*, VkAccelerationStructureCompatibilityKHR*, void> _vkGetDeviceAccelerationStructureCompatibilityKHR;
    private delegate* unmanaged[Cdecl]<VkDevice, VkAccelerationStructureBuildTypeKHR, VkAccelerationStructureBuildGeometryInfoKHR*, uint*, VkAccelerationStructureBuildSizesInfoKHR*, void> _vkGetAccelerationStructureBuildSizesKHR;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkCreateAccelerationStructureKHR(VkDevice device, VkAccelerationStructureCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkAccelerationStructureKHR* pAccelerationStructure)
    {
        return _vkCreateAccelerationStructureKHR(device, pCreateInfo, pAllocator, pAccelerationStructure);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkDestroyAccelerationStructureKHR(VkDevice device, VkAccelerationStructureKHR accelerationStructure, VkAllocationCallbacks* pAllocator)
    {
        _vkDestroyAccelerationStructureKHR(device, accelerationStructure, pAllocator);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdBuildAccelerationStructuresKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, VkAccelerationStructureBuildRangeInfoKHR** ppBuildRangeInfos)
    {
        _vkCmdBuildAccelerationStructuresKHR(commandBuffer, infoCount, pInfos, ppBuildRangeInfos);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, VkDeviceAddress* pIndirectDeviceAddresses, uint* pIndirectStrides, uint** ppMaxPrimitiveCounts)
    {
        _vkCmdBuildAccelerationStructuresIndirectKHR(commandBuffer, infoCount, pInfos, pIndirectDeviceAddresses, pIndirectStrides, ppMaxPrimitiveCounts);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkBuildAccelerationStructuresKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, VkAccelerationStructureBuildRangeInfoKHR** ppBuildRangeInfos)
    {
        return _vkBuildAccelerationStructuresKHR(device, deferredOperation, infoCount, pInfos, ppBuildRangeInfos);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkCopyAccelerationStructureKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, VkCopyAccelerationStructureInfoKHR* pInfo)
    {
        return _vkCopyAccelerationStructureKHR(device, deferredOperation, pInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkCopyAccelerationStructureToMemoryKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, VkCopyAccelerationStructureToMemoryInfoKHR* pInfo)
    {
        return _vkCopyAccelerationStructureToMemoryKHR(device, deferredOperation, pInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkCopyMemoryToAccelerationStructureKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, VkCopyMemoryToAccelerationStructureInfoKHR* pInfo)
    {
        return _vkCopyMemoryToAccelerationStructureKHR(device, deferredOperation, pInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkWriteAccelerationStructuresPropertiesKHR(VkDevice device, uint accelerationStructureCount, VkAccelerationStructureKHR* pAccelerationStructures, VkQueryType queryType, nint dataSize, void* pData, nint stride)
    {
        return _vkWriteAccelerationStructuresPropertiesKHR(device, accelerationStructureCount, pAccelerationStructures, queryType, dataSize, pData, stride);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdCopyAccelerationStructureKHR(VkCommandBuffer commandBuffer, VkCopyAccelerationStructureInfoKHR* pInfo)
    {
        _vkCmdCopyAccelerationStructureKHR(commandBuffer, pInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdCopyAccelerationStructureToMemoryKHR(VkCommandBuffer commandBuffer, VkCopyAccelerationStructureToMemoryInfoKHR* pInfo)
    {
        _vkCmdCopyAccelerationStructureToMemoryKHR(commandBuffer, pInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdCopyMemoryToAccelerationStructureKHR(VkCommandBuffer commandBuffer, VkCopyMemoryToAccelerationStructureInfoKHR* pInfo)
    {
        _vkCmdCopyMemoryToAccelerationStructureKHR(commandBuffer, pInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkDeviceAddress VkGetAccelerationStructureDeviceAddressKHR(VkDevice device, VkAccelerationStructureDeviceAddressInfoKHR* pInfo)
    {
        return _vkGetAccelerationStructureDeviceAddressKHR(device, pInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdWriteAccelerationStructuresPropertiesKHR(VkCommandBuffer commandBuffer, uint accelerationStructureCount, VkAccelerationStructureKHR* pAccelerationStructures, VkQueryType queryType, VkQueryPool queryPool, uint firstQuery)
    {
        _vkCmdWriteAccelerationStructuresPropertiesKHR(commandBuffer, accelerationStructureCount, pAccelerationStructures, queryType, queryPool, firstQuery);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkGetDeviceAccelerationStructureCompatibilityKHR(VkDevice device, VkAccelerationStructureVersionInfoKHR* pVersionInfo, VkAccelerationStructureCompatibilityKHR* pCompatibility)
    {
        _vkGetDeviceAccelerationStructureCompatibilityKHR(device, pVersionInfo, pCompatibility);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkGetAccelerationStructureBuildSizesKHR(VkDevice device, VkAccelerationStructureBuildTypeKHR buildType, VkAccelerationStructureBuildGeometryInfoKHR* pBuildInfo, uint* pMaxPrimitiveCounts, VkAccelerationStructureBuildSizesInfoKHR* pSizeInfo)
    {
        _vkGetAccelerationStructureBuildSizesKHR(device, buildType, pBuildInfo, pMaxPrimitiveCounts, pSizeInfo);
    }
}