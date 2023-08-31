using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceTilePropertiesFeaturesQCOM
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 tileProperties;

    public VkPhysicalDeviceTilePropertiesFeaturesQCOM()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TILE_PROPERTIES_FEATURES_QCOM;
    }
}