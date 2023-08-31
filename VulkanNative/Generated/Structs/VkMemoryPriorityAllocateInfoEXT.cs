using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkMemoryPriorityAllocateInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public float priority;

    public VkMemoryPriorityAllocateInfoEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_MEMORY_PRIORITY_ALLOCATE_INFO_EXT;
    }
}