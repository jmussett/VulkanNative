using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSpecializationInfo
{
    public uint MapEntryCount;
    public VkSpecializationMapEntry* PMapEntries;
    public nuint DataSize;
    public void* PData;
}