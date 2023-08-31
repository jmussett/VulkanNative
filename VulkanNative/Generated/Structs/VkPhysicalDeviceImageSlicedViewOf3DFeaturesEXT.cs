using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceImageSlicedViewOf3DFeaturesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 imageSlicedViewOf3D;

    public VkPhysicalDeviceImageSlicedViewOf3DFeaturesEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_SLICED_VIEW_OF_3D_FEATURES_EXT;
    }
}