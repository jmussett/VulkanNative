using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCommandBufferAllocateInfo
{
    public VkStructureType SType;
    public void* PNext;
    public VkCommandPool CommandPool;
    public VkCommandBufferLevel Level;
    public uint CommandBufferCount;
}