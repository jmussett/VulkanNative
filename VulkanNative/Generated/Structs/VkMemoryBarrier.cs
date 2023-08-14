using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkMemoryBarrier
{
    public VkStructureType SType;
    public void* PNext;
    public VkAccessFlags SrcAccessMask;
    public VkAccessFlags DstAccessMask;
}