using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkBufferCopy2
{
    public VkStructureType sType;
    public void* pNext;
    public VkDeviceSize srcOffset;
    public VkDeviceSize dstOffset;
    public VkDeviceSize size;
}