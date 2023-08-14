using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceRayTracingMotionBlurFeaturesNV
{
    public VkStructureType SType;
    public void* PNext;
    public VkBool32 RayTracingMotionBlur;
    public VkBool32 RayTracingMotionBlurPipelineTraceRaysIndirect;
}