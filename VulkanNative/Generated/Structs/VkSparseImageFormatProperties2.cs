using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSparseImageFormatProperties2
{
    public VkStructureType sType;
    public void* pNext;
    public VkSparseImageFormatProperties properties;

    public VkSparseImageFormatProperties2()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_SPARSE_IMAGE_FORMAT_PROPERTIES_2;
    }
}