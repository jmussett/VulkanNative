using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSemaphoreWaitInfo
{
    public VkStructureType SType;
    public void* PNext;
    public VkSemaphoreWaitFlags Flags;
    public uint SemaphoreCount;
    public VkSemaphore* PSemaphores;
    public ulong* PValues;
}