using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceFragmentShadingRateFeaturesKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 pipelineFragmentShadingRate;
    public VkBool32 primitiveFragmentShadingRate;
    public VkBool32 attachmentFragmentShadingRate;
}