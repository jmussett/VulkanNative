using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkTimelineSemaphoreSubmitInfo
{
    public VkStructureType SType;
    public void* PNext;
    public uint WaitSemaphoreValueCount;
    public ulong* PWaitSemaphoreValues;
    public uint SignalSemaphoreValueCount;
    public ulong* PSignalSemaphoreValues;
}