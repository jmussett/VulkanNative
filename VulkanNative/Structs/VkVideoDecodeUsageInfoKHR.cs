using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoDecodeUsageInfoKHR
{
    public VkStructureType SType;
    public void* PNext;
    public VkVideoDecodeUsageFlagsKHR VideoUsageHints;
}