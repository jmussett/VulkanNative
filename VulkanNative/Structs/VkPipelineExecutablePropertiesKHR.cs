﻿using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineExecutablePropertiesKHR
{
    public VkStructureType SType;
    public void* PNext;
    public VkShaderStageFlags Stages;
    public fixed char Name[(int)VulkanApiConstants.VK_MAX_DESCRIPTION_SIZE];
    public fixed char Description[(int)VulkanApiConstants.VK_MAX_DESCRIPTION_SIZE];
    public uint SubgroupSize;
}