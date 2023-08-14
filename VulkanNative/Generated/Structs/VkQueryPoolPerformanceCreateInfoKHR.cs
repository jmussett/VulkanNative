using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkQueryPoolPerformanceCreateInfoKHR
{
    public VkStructureType SType;
    public void* PNext;
    public uint QueueFamilyIndex;
    public uint CounterIndexCount;
    public uint* PCounterIndices;
}