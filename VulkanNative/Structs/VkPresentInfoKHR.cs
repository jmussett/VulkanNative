using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPresentInfoKHR
{
    public VkStructureType SType;
    public void* PNext;
    public uint WaitSemaphoreCount;
    public VkSemaphore* PWaitSemaphores;
    public uint SwapchainCount;
    public VkSwapchainKHR* PSwapchains;
    public uint* PImageIndices;
    public VkResult* PResults;
}