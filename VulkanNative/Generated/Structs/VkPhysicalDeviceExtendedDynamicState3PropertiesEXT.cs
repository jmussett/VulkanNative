using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceExtendedDynamicState3PropertiesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 dynamicPrimitiveTopologyUnrestricted;

    public VkPhysicalDeviceExtendedDynamicState3PropertiesEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTENDED_DYNAMIC_STATE_3_PROPERTIES_EXT;
    }
}