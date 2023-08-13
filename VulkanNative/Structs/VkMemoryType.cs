using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkMemoryType
{
    public VkMemoryPropertyFlags PropertyFlags;
    public uint HeapIndex;
}