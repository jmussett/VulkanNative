using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImageSwapchainCreateInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkSwapchainKHR swapchain;
}