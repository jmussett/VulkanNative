using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDevicePipelineExecutablePropertiesFeaturesKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 pipelineExecutableInfo;

    public VkPhysicalDevicePipelineExecutablePropertiesFeaturesKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_EXECUTABLE_PROPERTIES_FEATURES_KHR;
    }
}