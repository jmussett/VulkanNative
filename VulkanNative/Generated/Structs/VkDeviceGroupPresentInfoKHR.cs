using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDeviceGroupPresentInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public uint swapchainCount;
    public uint* pDeviceMasks;
    public VkDeviceGroupPresentModeFlagsKHR mode;

    public VkDeviceGroupPresentInfoKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_DEVICE_GROUP_PRESENT_INFO_KHR;
    }
}