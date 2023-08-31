using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceCustomBorderColorFeaturesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 customBorderColors;
    public VkBool32 customBorderColorWithoutFormat;

    public VkPhysicalDeviceCustomBorderColorFeaturesEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CUSTOM_BORDER_COLOR_FEATURES_EXT;
    }
}