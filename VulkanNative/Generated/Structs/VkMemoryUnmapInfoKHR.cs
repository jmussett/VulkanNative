using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkMemoryUnmapInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkMemoryUnmapFlagsKHR flags;
    public VkDeviceMemory memory;

    public VkMemoryUnmapInfoKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_MEMORY_UNMAP_INFO_KHR;
    }
}