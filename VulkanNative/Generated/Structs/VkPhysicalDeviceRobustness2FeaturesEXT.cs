using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceRobustness2FeaturesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 robustBufferAccess2;
    public VkBool32 robustImageAccess2;
    public VkBool32 nullDescriptor;

    public VkPhysicalDeviceRobustness2FeaturesEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ROBUSTNESS_2_FEATURES_EXT;
    }
}