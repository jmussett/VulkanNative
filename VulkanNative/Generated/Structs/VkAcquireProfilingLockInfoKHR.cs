using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkAcquireProfilingLockInfoKHR
{
    public VkStructureType SType;
    public void* PNext;
    public VkAcquireProfilingLockFlagsKHR Flags;
    public ulong Timeout;
}