using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkBufferCopy
{
    public VkDeviceSize srcOffset;
    public VkDeviceSize dstOffset;
    public VkDeviceSize size;
}