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

    public VkCopyBufferInfo2()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_COPY_BUFFER_INFO_2;
    }
}