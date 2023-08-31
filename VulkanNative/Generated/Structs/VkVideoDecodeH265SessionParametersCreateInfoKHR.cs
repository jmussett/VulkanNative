﻿using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoDecodeH265SessionParametersCreateInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public uint maxStdVPSCount;
    public uint maxStdSPSCount;
    public uint maxStdPPSCount;
    public VkVideoDecodeH265SessionParametersAddInfoKHR* pParametersAddInfo;
}