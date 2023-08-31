using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkAcquireProfilingLockInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkAcquireProfilingLockFlagsKHR flags;
    public ulong timeout;

    public VkAcquireProfilingLockInfoKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_ACQUIRE_PROFILING_LOCK_INFO_KHR;
    }
}