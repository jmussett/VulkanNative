using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkBufferCopy2
{
    public VkStructureType SType;
    public void* PNext;
    public VkDeviceSize SrcOffset;
    public VkDeviceSize DstOffset;
    public VkDeviceSize Size;
}