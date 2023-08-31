using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceLegacyDitheringFeaturesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 legacyDithering;

    public VkPhysicalDeviceLegacyDitheringFeaturesEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LEGACY_DITHERING_FEATURES_EXT;
    }
}