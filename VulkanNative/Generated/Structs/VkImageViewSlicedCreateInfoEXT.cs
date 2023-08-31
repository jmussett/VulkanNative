using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImageViewSlicedCreateInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public uint sliceOffset;
    public uint sliceCount;
}