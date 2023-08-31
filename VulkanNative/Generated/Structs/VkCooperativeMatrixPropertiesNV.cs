﻿using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCooperativeMatrixPropertiesNV
{
    public VkStructureType sType;
    public void* pNext;
    public uint MSize;
    public uint NSize;
    public uint KSize;
    public VkComponentTypeKHR AType;
    public VkComponentTypeKHR BType;
    public VkComponentTypeKHR CType;
    public VkComponentTypeKHR DType;
    public VkScopeKHR scope;
}