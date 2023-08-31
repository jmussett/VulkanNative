using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkMappedMemoryRange
{
    public VkStructureType sType;
    public void* pNext;
    public VkDeviceMemory memory;
    public VkDeviceSize offset;
    public VkDeviceSize size;

    public VkMappedMemoryRange()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_MAPPED_MEMORY_RANGE;
    }
}