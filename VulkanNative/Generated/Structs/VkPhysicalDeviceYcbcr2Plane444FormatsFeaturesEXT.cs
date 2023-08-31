using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceYcbcr2Plane444FormatsFeaturesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 ycbcr2plane444Formats;

    public VkPhysicalDeviceYcbcr2Plane444FormatsFeaturesEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_YCBCR_2_PLANE_444_FORMATS_FEATURES_EXT;
    }
}