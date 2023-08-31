using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkBindImageMemorySwapchainInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkSwapchainKHR swapchain;
    public uint imageIndex;

    public VkBindImageMemorySwapchainInfoKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_BIND_IMAGE_MEMORY_SWAPCHAIN_INFO_KHR;
    }
}