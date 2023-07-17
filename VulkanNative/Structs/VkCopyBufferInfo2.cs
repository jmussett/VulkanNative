using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCopyBufferInfo2
{
    public VkStructureType sType;
    public void* pNext;
    public VkBuffer srcBuffer;
    public VkBuffer dstBuffer;
    public uint regionCount;
    public VkBufferCopy2* pRegions;
}