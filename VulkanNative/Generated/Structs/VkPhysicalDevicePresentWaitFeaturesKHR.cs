using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDevicePresentWaitFeaturesKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 presentWait;

    public VkPhysicalDevicePresentWaitFeaturesKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRESENT_WAIT_FEATURES_KHR;
    }
}