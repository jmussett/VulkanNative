using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkTimelineSemaphoreSubmitInfo
{
    public VkStructureType sType;
    public void* pNext;
    public uint waitSemaphoreValueCount;
    public ulong* pWaitSemaphoreValues;
    public uint signalSemaphoreValueCount;
    public ulong* pSignalSemaphoreValues;
}