using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkAcquireNextImageInfoKHR
{
    public VkStructureType SType;
    public void* PNext;
    public VkSwapchainKHR Swapchain;
    public ulong Timeout;
    public VkSemaphore Semaphore;
    public VkFence Fence;
    public uint DeviceMask;
}