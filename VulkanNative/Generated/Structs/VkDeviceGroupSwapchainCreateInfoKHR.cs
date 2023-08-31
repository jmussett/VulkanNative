using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDeviceGroupSwapchainCreateInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkDeviceGroupPresentModeFlagsKHR modes;

    public VkDeviceGroupSwapchainCreateInfoKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_DEVICE_GROUP_SWAPCHAIN_CREATE_INFO_KHR;
    }
}