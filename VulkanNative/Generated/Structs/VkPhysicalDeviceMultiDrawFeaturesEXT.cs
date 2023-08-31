using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceMultiDrawFeaturesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 multiDraw;

    public VkPhysicalDeviceMultiDrawFeaturesEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTI_DRAW_FEATURES_EXT;
    }
}