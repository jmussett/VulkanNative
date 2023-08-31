using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkMemoryMapInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkMemoryMapFlags flags;
    public VkDeviceMemory memory;
    public VkDeviceSize offset;
    public VkDeviceSize size;
}