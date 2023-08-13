using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDeviceGroupSubmitInfo
{
    public VkStructureType sType;
    public void* pNext;
    public uint waitSemaphoreCount;
    public uint* pWaitSemaphoreDeviceIndices;
    public uint commandBufferCount;
    public uint* pCommandBufferDeviceMasks;
    public uint signalSemaphoreCount;
    public uint* pSignalSemaphoreDeviceIndices;
}