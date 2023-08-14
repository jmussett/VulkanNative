﻿using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoDecodeH265SessionParametersCreateInfoKHR
{
    public VkStructureType SType;
    public void* PNext;
    public uint MaxStdVPSCount;
    public uint MaxStdSPSCount;
    public uint MaxStdPPSCount;
    public VkVideoDecodeH265SessionParametersAddInfoKHR* PParametersAddInfo;
}