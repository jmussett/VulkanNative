using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceImageRobustnessFeatures
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 robustImageAccess;

    public VkPhysicalDeviceImageRobustnessFeatures()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_ROBUSTNESS_FEATURES;
    }
}