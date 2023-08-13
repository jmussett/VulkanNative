using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkFilterCubicImageViewImageFormatPropertiesEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkBool32 FilterCubic;
    public VkBool32 FilterCubicMinmax;
}