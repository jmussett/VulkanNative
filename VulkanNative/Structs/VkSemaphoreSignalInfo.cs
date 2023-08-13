using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSemaphoreSignalInfo
{
    public VkStructureType SType;
    public void* PNext;
    public VkSemaphore Semaphore;
    public ulong Value;
}