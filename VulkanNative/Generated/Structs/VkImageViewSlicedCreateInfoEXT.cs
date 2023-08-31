using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImageViewSlicedCreateInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public uint sliceOffset;
    public uint sliceCount;

    public VkImageViewSlicedCreateInfoEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_IMAGE_VIEW_SLICED_CREATE_INFO_EXT;
    }
}