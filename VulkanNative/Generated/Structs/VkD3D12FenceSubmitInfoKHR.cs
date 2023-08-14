using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkD3D12FenceSubmitInfoKHR
{
    public VkStructureType SType;
    public void* PNext;
    public uint WaitSemaphoreValuesCount;
    public ulong* PWaitSemaphoreValues;
    public uint SignalSemaphoreValuesCount;
    public ulong* PSignalSemaphoreValues;
}