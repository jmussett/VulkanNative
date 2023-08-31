using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSubmitInfo2
{
    public VkStructureType sType;
    public void* pNext;
    public VkSubmitFlags flags;
    public uint waitSemaphoreInfoCount;
    public VkSemaphoreSubmitInfo* pWaitSemaphoreInfos;
    public uint commandBufferInfoCount;
    public VkCommandBufferSubmitInfo* pCommandBufferInfos;
    public uint signalSemaphoreInfoCount;
    public VkSemaphoreSubmitInfo* pSignalSemaphoreInfos;

    public VkSubmitInfo2()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_SUBMIT_INFO_2;
    }
}