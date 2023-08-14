using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkMemoryHeap
{
    public VkDeviceSize Size;
    public VkMemoryHeapFlags Flags;
}