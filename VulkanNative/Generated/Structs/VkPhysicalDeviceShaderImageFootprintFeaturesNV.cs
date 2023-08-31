using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceShaderImageFootprintFeaturesNV
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 imageFootprint;

    public VkPhysicalDeviceShaderImageFootprintFeaturesNV()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_IMAGE_FOOTPRINT_FEATURES_NV;
    }
}