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

    public VkTimelineSemaphoreSubmitInfo()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_TIMELINE_SEMAPHORE_SUBMIT_INFO;
    }
}