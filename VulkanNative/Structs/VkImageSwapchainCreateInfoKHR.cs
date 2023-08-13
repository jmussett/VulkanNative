using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImageSwapchainCreateInfoKHR
{
    public VkStructureType SType;
    public void* PNext;
    public VkSwapchainKHR Swapchain;
}