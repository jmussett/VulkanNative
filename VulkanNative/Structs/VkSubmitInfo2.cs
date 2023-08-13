using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSubmitInfo2
{
    public VkStructureType SType;
    public void* PNext;
    public VkSubmitFlags Flags;
    public uint WaitSemaphoreInfoCount;
    public VkSemaphoreSubmitInfo* PWaitSemaphoreInfos;
    public uint CommandBufferInfoCount;
    public VkCommandBufferSubmitInfo* PCommandBufferInfos;
    public uint SignalSemaphoreInfoCount;
    public VkSemaphoreSubmitInfo* PSignalSemaphoreInfos;
}