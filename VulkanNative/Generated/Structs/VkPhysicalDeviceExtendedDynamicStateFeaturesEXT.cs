using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceExtendedDynamicStateFeaturesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 extendedDynamicState;

    public VkPhysicalDeviceExtendedDynamicStateFeaturesEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTENDED_DYNAMIC_STATE_FEATURES_EXT;
    }
}