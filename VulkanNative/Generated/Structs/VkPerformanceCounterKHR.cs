﻿using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPerformanceCounterKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkPerformanceCounterUnitKHR unit;
    public VkPerformanceCounterScopeKHR scope;
    public VkPerformanceCounterStorageKHR storage;
    public fixed byte uuid[(int)VulkanApiConstants.VK_UUID_SIZE];

    public VkPerformanceCounterKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PERFORMANCE_COUNTER_KHR;
    }
}