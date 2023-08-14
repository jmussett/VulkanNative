using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceMemoryProperties
{
    public uint MemoryTypeCount;
    public VkMemoryType* MemoryTypes;
    public uint MemoryHeapCount;
    public VkMemoryHeap* MemoryHeaps;
}