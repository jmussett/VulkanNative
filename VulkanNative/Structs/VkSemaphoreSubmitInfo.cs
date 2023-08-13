using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSemaphoreSubmitInfo
{
    public VkStructureType SType;
    public void* PNext;
    public VkSemaphore Semaphore;
    public ulong Value;
    public VkPipelineStageFlags2 StageMask;
    public uint DeviceIndex;
}