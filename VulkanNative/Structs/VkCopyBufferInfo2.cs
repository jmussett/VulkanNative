using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCopyBufferInfo2
{
    public VkStructureType SType;
    public void* PNext;
    public VkBuffer SrcBuffer;
    public VkBuffer DstBuffer;
    public uint RegionCount;
    public VkBufferCopy2* PRegions;
}