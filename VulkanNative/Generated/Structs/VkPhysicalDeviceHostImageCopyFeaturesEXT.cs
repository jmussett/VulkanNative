using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceHostImageCopyFeaturesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 hostImageCopy;

    public VkPhysicalDeviceHostImageCopyFeaturesEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_HOST_IMAGE_COPY_FEATURES_EXT;
    }
}