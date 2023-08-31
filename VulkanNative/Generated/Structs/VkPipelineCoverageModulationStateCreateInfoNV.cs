﻿using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineCoverageModulationStateCreateInfoNV
{
    public VkStructureType sType;
    public void* pNext;
    public VkPipelineCoverageModulationStateCreateFlagsNV flags;
    public VkCoverageModulationModeNV coverageModulationMode;
    public VkBool32 coverageModulationTableEnable;
    public uint coverageModulationTableCount;
    public float* pCoverageModulationTable;
}