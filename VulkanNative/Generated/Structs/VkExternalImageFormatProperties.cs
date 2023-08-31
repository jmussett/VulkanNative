using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkExternalImageFormatProperties
{
    public VkStructureType sType;
    public void* pNext;
    public VkExternalMemoryProperties externalMemoryProperties;

    public VkExternalImageFormatProperties()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_EXTERNAL_IMAGE_FORMAT_PROPERTIES;
    }
}