﻿using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineShaderStageCreateInfo
{
    public VkStructureType sType;
    public void* pNext;
    public VkPipelineShaderStageCreateFlags flags;
    public VkShaderStageFlagBits stage;
    public VkShaderModule module;
    public char* pName;
    public VkSpecializationInfo* pSpecializationInfo;
}