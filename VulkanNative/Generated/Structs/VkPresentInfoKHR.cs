using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPresentInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public uint waitSemaphoreCount;
    public VkSemaphore* pWaitSemaphores;
    public uint swapchainCount;
    public VkSwapchainKHR* pSwapchains;
    public uint* pImageIndices;
    public VkResult* pResults;

    public VkPresentInfoKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PRESENT_INFO_KHR;
    }
}