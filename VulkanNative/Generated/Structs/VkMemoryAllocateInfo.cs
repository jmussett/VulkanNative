using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkMemoryAllocateInfo
{
    public VkStructureType sType;
    public void* pNext;
    public VkDeviceSize allocationSize;
    public uint memoryTypeIndex;

    public VkMemoryAllocateInfo()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_MEMORY_ALLOCATE_INFO;
    }
}