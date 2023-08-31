using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSwapchainPresentFenceInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public uint swapchainCount;
    public VkFence* pFences;

    public VkSwapchainPresentFenceInfoEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_SWAPCHAIN_PRESENT_FENCE_INFO_EXT;
    }
}