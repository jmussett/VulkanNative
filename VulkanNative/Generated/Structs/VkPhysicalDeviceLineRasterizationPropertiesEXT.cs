using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceLineRasterizationPropertiesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public uint lineSubPixelPrecisionBits;

    public VkPhysicalDeviceLineRasterizationPropertiesEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LINE_RASTERIZATION_PROPERTIES_EXT;
    }
}