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

    public VkMemoryMapInfoKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_MEMORY_MAP_INFO_KHR;
    }
}