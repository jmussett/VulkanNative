using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceCustomBorderColorPropertiesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public uint maxCustomBorderColorSamplers;

    public VkPhysicalDeviceCustomBorderColorPropertiesEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CUSTOM_BORDER_COLOR_PROPERTIES_EXT;
    }
}