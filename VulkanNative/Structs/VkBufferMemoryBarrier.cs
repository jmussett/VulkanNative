using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkBufferMemoryBarrier
{
    public VkStructureType SType;
    public void* PNext;
    public VkAccessFlags SrcAccessMask;
    public VkAccessFlags DstAccessMask;
    public uint SrcQueueFamilyIndex;
    public uint DstQueueFamilyIndex;
    public VkBuffer Buffer;
    public VkDeviceSize Offset;
    public VkDeviceSize Size;
}