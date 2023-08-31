using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkAcquireNextImageInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkSwapchainKHR swapchain;
    public ulong timeout;
    public VkSemaphore semaphore;
    public VkFence fence;
    public uint deviceMask;

    public VkAcquireNextImageInfoKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_ACQUIRE_NEXT_IMAGE_INFO_KHR;
    }
}