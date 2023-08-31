using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSwapchainCounterCreateInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkSurfaceCounterFlagsEXT surfaceCounters;

    public VkSwapchainCounterCreateInfoEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_SWAPCHAIN_COUNTER_CREATE_INFO_EXT;
    }
}