using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkBufferCopy
{
    public VkDeviceSize SrcOffset;
    public VkDeviceSize DstOffset;
    public VkDeviceSize Size;
}