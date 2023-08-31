using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceYcbcrImageArraysFeaturesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 ycbcrImageArrays;

    public VkPhysicalDeviceYcbcrImageArraysFeaturesEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_YCBCR_IMAGE_ARRAYS_FEATURES_EXT;
    }
}