using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceRayTracingMotionBlurFeaturesNV
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 rayTracingMotionBlur;
    public VkBool32 rayTracingMotionBlurPipelineTraceRaysIndirect;
}