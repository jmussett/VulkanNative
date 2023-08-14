﻿using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkShaderResourceUsageAMD
{
    public uint NumUsedVgprs;
    public uint NumUsedSgprs;
    public uint LdsSizePerLocalWorkGroup;
    public nint LdsUsageSizeInBytes;
    public nint ScratchMemUsageInBytes;
}