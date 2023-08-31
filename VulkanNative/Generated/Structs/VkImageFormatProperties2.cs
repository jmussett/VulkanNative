using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImageFormatProperties2
{
    public VkStructureType sType;
    public void* pNext;
    public VkImageFormatProperties imageFormatProperties;

    public VkImageFormatProperties2()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_IMAGE_FORMAT_PROPERTIES_2;
    }
}