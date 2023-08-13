using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceFragmentShadingRateFeaturesKHR
{
    public VkStructureType SType;
    public void* PNext;
    public VkBool32 PipelineFragmentShadingRate;
    public VkBool32 PrimitiveFragmentShadingRate;
    public VkBool32 AttachmentFragmentShadingRate;
}