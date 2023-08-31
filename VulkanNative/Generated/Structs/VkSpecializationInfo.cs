using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSpecializationInfo
{
    public uint mapEntryCount;
    public VkSpecializationMapEntry* pMapEntries;
    public nuint dataSize;
    public void* pData;
}