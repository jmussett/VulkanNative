using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCommandBufferAllocateInfo
{
    public VkStructureType sType;
    public void* pNext;
    public VkCommandPool commandPool;
    public VkCommandBufferLevel level;
    public uint commandBufferCount;
}