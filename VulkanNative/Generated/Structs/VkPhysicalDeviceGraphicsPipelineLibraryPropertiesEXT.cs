using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceGraphicsPipelineLibraryPropertiesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 graphicsPipelineLibraryFastLinking;
    public VkBool32 graphicsPipelineLibraryIndependentInterpolationDecoration;

    public VkPhysicalDeviceGraphicsPipelineLibraryPropertiesEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_GRAPHICS_PIPELINE_LIBRARY_PROPERTIES_EXT;
    }
}