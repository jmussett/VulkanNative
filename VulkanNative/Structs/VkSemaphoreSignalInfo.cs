using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSemaphoreSignalInfo
{
    public VkStructureType sType;
    public void* pNext;
    public VkSemaphore semaphore;
    public ulong value;
}