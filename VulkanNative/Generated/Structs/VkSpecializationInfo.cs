using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSpecializationInfo
{
    public uint MapEntryCount;
    public VkSpecializationMapEntry* PMapEntries;
    public nint DataSize;
    public void* PData;
}