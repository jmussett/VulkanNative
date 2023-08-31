using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceRayTracingMotionBlurFeaturesNV
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 rayTracingMotionBlur;
    public VkBool32 rayTracingMotionBlurPipelineTraceRaysIndirect;

    public VkPhysicalDeviceRayTracingMotionBlurFeaturesNV()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_MOTION_BLUR_FEATURES_NV;
    }
}