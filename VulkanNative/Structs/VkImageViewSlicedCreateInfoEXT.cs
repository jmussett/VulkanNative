using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImageViewSlicedCreateInfoEXT
{
    public VkStructureType SType;
    public void* PNext;
    public uint SliceOffset;
    public uint SliceCount;
}