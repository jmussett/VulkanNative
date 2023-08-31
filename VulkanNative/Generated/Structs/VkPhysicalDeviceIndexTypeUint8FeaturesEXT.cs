using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceIndexTypeUint8FeaturesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 indexTypeUint8;

    public VkPhysicalDeviceIndexTypeUint8FeaturesEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INDEX_TYPE_UINT8_FEATURES_EXT;
    }
}