using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDevicePipelineProtectedAccessFeaturesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 pipelineProtectedAccess;

    public VkPhysicalDevicePipelineProtectedAccessFeaturesEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_PROTECTED_ACCESS_FEATURES_EXT;
    }
}