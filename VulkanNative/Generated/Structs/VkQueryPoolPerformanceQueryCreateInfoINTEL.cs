using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkQueryPoolPerformanceQueryCreateInfoINTEL
{
    public VkStructureType SType;
    public void* PNext;
    public VkQueryPoolSamplingModeINTEL PerformanceCountersSampling;
}