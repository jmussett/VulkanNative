using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCommandBufferSubmitInfo
{
    public VkStructureType SType;
    public void* PNext;
    public VkCommandBuffer CommandBuffer;
    public uint DeviceMask;
}