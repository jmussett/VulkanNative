using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDeviceGroupPresentCapabilitiesKHR
{
    public VkStructureType sType;
    public void* pNext;
    public fixed uint presentMask[(int)VulkanApiConstants.VK_MAX_DEVICE_GROUP_SIZE];
    public VkDeviceGroupPresentModeFlagsKHR modes;
}