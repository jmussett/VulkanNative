using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSparseImageMemoryRequirements2
{
    public VkStructureType sType;
    public void* pNext;
    public VkSparseImageMemoryRequirements memoryRequirements;

    public VkSparseImageMemoryRequirements2()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_SPARSE_IMAGE_MEMORY_REQUIREMENTS_2;
    }
}