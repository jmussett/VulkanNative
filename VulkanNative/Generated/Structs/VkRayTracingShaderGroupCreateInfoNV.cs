﻿using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkRayTracingShaderGroupCreateInfoNV
{
    public VkStructureType sType;
    public void* pNext;
    public VkRayTracingShaderGroupTypeKHR type;
    public uint generalShader;
    public uint closestHitShader;
    public uint anyHitShader;
    public uint intersectionShader;
}