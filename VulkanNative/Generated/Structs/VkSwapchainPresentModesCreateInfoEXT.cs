using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSwapchainPresentModesCreateInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public uint presentModeCount;
    public VkPresentModeKHR* pPresentModes;

    public VkSwapchainPresentModesCreateInfoEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_SWAPCHAIN_PRESENT_MODES_CREATE_INFO_EXT;
    }
}