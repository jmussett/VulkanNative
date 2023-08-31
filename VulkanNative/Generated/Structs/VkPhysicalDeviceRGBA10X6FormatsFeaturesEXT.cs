using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceRGBA10X6FormatsFeaturesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 formatRgba10x6WithoutYCbCrSampler;

    public VkPhysicalDeviceRGBA10X6FormatsFeaturesEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RGBA10X6_FORMATS_FEATURES_EXT;
    }
}