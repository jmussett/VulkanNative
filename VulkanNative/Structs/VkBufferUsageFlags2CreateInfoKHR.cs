using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkBufferUsageFlags2CreateInfoKHR
{
    public VkStructureType SType;
    public void* PNext;
    public VkBufferUsageFlags2KHR Usage;
}