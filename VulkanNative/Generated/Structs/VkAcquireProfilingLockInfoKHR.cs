using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkAcquireProfilingLockInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkAcquireProfilingLockFlagsKHR flags;
    public ulong timeout;
}