using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkMemoryDedicatedAllocateInfo
{
    public VkStructureType sType;
    public void* pNext;
    public VkImage image;
    public VkBuffer buffer;

    public VkMemoryDedicatedAllocateInfo()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_MEMORY_DEDICATED_ALLOCATE_INFO;
    }
}