using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkMemoryType
{
    public VkMemoryPropertyFlags propertyFlags;
    public uint heapIndex;
}