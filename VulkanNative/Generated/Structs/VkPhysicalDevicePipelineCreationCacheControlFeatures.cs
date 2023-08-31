using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDevicePipelineCreationCacheControlFeatures
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 pipelineCreationCacheControl;

    public VkPhysicalDevicePipelineCreationCacheControlFeatures()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_CREATION_CACHE_CONTROL_FEATURES;
    }
}