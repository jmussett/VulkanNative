using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkMemoryBarrier2
{
    public VkStructureType SType;
    public void* PNext;
    public VkPipelineStageFlags2 SrcStageMask;
    public VkAccessFlags2 SrcAccessMask;
    public VkPipelineStageFlags2 DstStageMask;
    public VkAccessFlags2 DstAccessMask;
}