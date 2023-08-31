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

    public VkBufferCopy2()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_BUFFER_COPY_2;
    }
}