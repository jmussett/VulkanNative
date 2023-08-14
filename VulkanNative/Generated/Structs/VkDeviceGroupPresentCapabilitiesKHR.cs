using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDeviceGroupPresentCapabilitiesKHR
{
    public VkStructureType SType;
    public void* PNext;
    public fixed uint PresentMask[(int)VulkanApiConstants.VK_MAX_DEVICE_GROUP_SIZE];
    public VkDeviceGroupPresentModeFlagsKHR Modes;
}