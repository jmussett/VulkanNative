using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkFilterCubicImageViewImageFormatPropertiesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 filterCubic;
    public VkBool32 filterCubicMinmax;

    public VkFilterCubicImageViewImageFormatPropertiesEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_FILTER_CUBIC_IMAGE_VIEW_IMAGE_FORMAT_PROPERTIES_EXT;
    }
}