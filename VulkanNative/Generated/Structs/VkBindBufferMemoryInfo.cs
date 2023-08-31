using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkBindBufferMemoryInfo
{
    public VkStructureType sType;
    public void* pNext;
    public VkBuffer buffer;
    public VkDeviceMemory memory;
    public VkDeviceSize memoryOffset;
}