﻿using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkAccelerationStructureTrianglesOpacityMicromapEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkIndexType indexType;
    public VkDeviceOrHostAddressConstKHR indexBuffer;
    public VkDeviceSize indexStride;
    public uint baseTriangle;
    public uint usageCountsCount;
    public VkMicromapUsageEXT* pUsageCounts;
    public VkMicromapUsageEXT** ppUsageCounts;
    public VkMicromapEXT micromap;

    public VkAccelerationStructureTrianglesOpacityMicromapEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_TRIANGLES_OPACITY_MICROMAP_EXT;
    }
}