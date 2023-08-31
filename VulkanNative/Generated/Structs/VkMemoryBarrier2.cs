using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkMemoryBarrier2
{
    public VkStructureType sType;
    public void* pNext;
    public VkPipelineStageFlags2 srcStageMask;
    public VkAccessFlags2 srcAccessMask;
    public VkPipelineStageFlags2 dstStageMask;
    public VkAccessFlags2 dstAccessMask;
}