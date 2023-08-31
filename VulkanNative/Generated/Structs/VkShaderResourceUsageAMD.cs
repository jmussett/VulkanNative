using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkShaderResourceUsageAMD
{
    public uint numUsedVgprs;
    public uint numUsedSgprs;
    public uint ldsSizePerLocalWorkGroup;
    public nuint ldsUsageSizeInBytes;
    public nuint scratchMemUsageInBytes;
}