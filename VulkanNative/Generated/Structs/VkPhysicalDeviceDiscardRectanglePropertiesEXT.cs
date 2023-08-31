using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceDiscardRectanglePropertiesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public uint maxDiscardRectangles;

    public VkPhysicalDeviceDiscardRectanglePropertiesEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DISCARD_RECTANGLE_PROPERTIES_EXT;
    }
}