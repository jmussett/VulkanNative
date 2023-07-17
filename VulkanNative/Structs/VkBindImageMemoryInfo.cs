using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkBindImageMemoryInfo
{
    public VkStructureType sType;
    public void* pNext;
    public VkImage image;
    public VkDeviceMemory memory;
    public VkDeviceSize memoryOffset;
}