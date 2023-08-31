using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDevicePresentIdFeaturesKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 presentId;

    public VkPhysicalDevicePresentIdFeaturesKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRESENT_ID_FEATURES_KHR;
    }
}