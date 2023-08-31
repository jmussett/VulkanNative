using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceImage2DViewOf3DFeaturesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 image2DViewOf3D;
    public VkBool32 sampler2DViewOf3D;

    public VkPhysicalDeviceImage2DViewOf3DFeaturesEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_2D_VIEW_OF_3D_FEATURES_EXT;
    }
}