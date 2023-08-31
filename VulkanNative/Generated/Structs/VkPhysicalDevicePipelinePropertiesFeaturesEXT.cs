using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDevicePipelinePropertiesFeaturesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 pipelinePropertiesIdentifier;

    public VkPhysicalDevicePipelinePropertiesFeaturesEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_PROPERTIES_FEATURES_EXT;
    }
}