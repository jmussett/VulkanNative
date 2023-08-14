using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDeviceGroupSubmitInfo
{
    public VkStructureType SType;
    public void* PNext;
    public uint WaitSemaphoreCount;
    public uint* PWaitSemaphoreDeviceIndices;
    public uint CommandBufferCount;
    public uint* PCommandBufferDeviceMasks;
    public uint SignalSemaphoreCount;
    public uint* PSignalSemaphoreDeviceIndices;
}