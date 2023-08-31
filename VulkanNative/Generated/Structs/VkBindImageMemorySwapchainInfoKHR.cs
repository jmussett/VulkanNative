using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkBindImageMemorySwapchainInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkSwapchainKHR swapchain;
    public uint imageIndex;
}