using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkBindImageMemorySwapchainInfoKHR
{
    public VkStructureType SType;
    public void* PNext;
    public VkSwapchainKHR Swapchain;
    public uint ImageIndex;
}