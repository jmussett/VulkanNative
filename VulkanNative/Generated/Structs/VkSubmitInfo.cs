using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSubmitInfo
{
    public VkStructureType sType;
    public void* pNext;
    public uint waitSemaphoreCount;
    public VkSemaphore* pWaitSemaphores;
    public VkPipelineStageFlags* pWaitDstStageMask;
    public uint commandBufferCount;
    public VkCommandBuffer* pCommandBuffers;
    public uint signalSemaphoreCount;
    public VkSemaphore* pSignalSemaphores;
}