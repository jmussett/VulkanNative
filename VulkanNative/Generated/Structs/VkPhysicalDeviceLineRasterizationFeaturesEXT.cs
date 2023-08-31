using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceLineRasterizationFeaturesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 rectangularLines;
    public VkBool32 bresenhamLines;
    public VkBool32 smoothLines;
    public VkBool32 stippledRectangularLines;
    public VkBool32 stippledBresenhamLines;
    public VkBool32 stippledSmoothLines;

    public VkPhysicalDeviceLineRasterizationFeaturesEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LINE_RASTERIZATION_FEATURES_EXT;
    }
}