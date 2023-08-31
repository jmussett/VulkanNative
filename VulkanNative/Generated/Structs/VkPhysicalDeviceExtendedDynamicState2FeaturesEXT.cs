using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceExtendedDynamicState2FeaturesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 extendedDynamicState2;
    public VkBool32 extendedDynamicState2LogicOp;
    public VkBool32 extendedDynamicState2PatchControlPoints;

    public VkPhysicalDeviceExtendedDynamicState2FeaturesEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTENDED_DYNAMIC_STATE_2_FEATURES_EXT;
    }
}