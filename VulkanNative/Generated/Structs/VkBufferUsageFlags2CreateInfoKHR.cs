using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkBufferUsageFlags2CreateInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkBufferUsageFlags2KHR usage;
}