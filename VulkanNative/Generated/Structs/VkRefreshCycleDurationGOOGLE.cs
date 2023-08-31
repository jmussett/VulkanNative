using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkRefreshCycleDurationGOOGLE
{
    public ulong refreshDuration;
}