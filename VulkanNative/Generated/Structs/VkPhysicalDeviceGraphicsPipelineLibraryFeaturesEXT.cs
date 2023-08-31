using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceGraphicsPipelineLibraryFeaturesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 graphicsPipelineLibrary;

    public VkPhysicalDeviceGraphicsPipelineLibraryFeaturesEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_GRAPHICS_PIPELINE_LIBRARY_FEATURES_EXT;
    }
}