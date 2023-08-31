using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkFilterCubicImageViewImageFormatPropertiesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 filterCubic;
    public VkBool32 filterCubicMinmax;
}