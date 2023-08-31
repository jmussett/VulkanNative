using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSemaphoreSubmitInfo
{
    public VkStructureType sType;
    public void* pNext;
    public VkSemaphore semaphore;
    public ulong value;
    public VkPipelineStageFlags2 stageMask;
    public uint deviceIndex;

    public VkSemaphoreSubmitInfo()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_SEMAPHORE_SUBMIT_INFO;
    }
}