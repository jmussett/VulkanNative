using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoDecodeUsageInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkVideoDecodeUsageFlagsKHR videoUsageHints;
}