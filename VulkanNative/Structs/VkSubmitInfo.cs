using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSubmitInfo
{
    public VkStructureType SType;
    public void* PNext;
    public uint WaitSemaphoreCount;
    public VkSemaphore* PWaitSemaphores;
    public VkPipelineStageFlags* PWaitDstStageMask;
    public uint CommandBufferCount;
    public VkCommandBuffer* PCommandBuffers;
    public uint SignalSemaphoreCount;
    public VkSemaphore* PSignalSemaphores;
}