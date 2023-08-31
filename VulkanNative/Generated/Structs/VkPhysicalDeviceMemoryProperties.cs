using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceMemoryProperties
{
    public uint memoryTypeCount;
    public VkMemoryType* memoryTypes;
    public uint memoryHeapCount;
    public VkMemoryHeap* memoryHeaps;
}