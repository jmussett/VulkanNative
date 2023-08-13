using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkBufferMemoryBarrier2
{
    public VkStructureType SType;
    public void* PNext;
    public VkPipelineStageFlags2 SrcStageMask;
    public VkAccessFlags2 SrcAccessMask;
    public VkPipelineStageFlags2 DstStageMask;
    public VkAccessFlags2 DstAccessMask;
    public uint SrcQueueFamilyIndex;
    public uint DstQueueFamilyIndex;
    public VkBuffer Buffer;
    public VkDeviceSize Offset;
    public VkDeviceSize Size;
}