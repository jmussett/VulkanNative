using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSemaphoreWaitInfo
{
    public VkStructureType sType;
    public void* pNext;
    public VkSemaphoreWaitFlags flags;
    public uint semaphoreCount;
    public VkSemaphore* pSemaphores;
    public ulong* pValues;
}