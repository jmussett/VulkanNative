using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImageSparseMemoryRequirementsInfo2
{
    public VkStructureType sType;
    public void* pNext;
    public VkImage image;

    public VkImageSparseMemoryRequirementsInfo2()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_IMAGE_SPARSE_MEMORY_REQUIREMENTS_INFO_2;
    }
}