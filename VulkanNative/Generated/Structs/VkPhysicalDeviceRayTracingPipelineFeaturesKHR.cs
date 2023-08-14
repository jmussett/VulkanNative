using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceRayTracingPipelineFeaturesKHR
{
    public VkStructureType SType;
    public void* PNext;
    public VkBool32 RayTracingPipeline;
    public VkBool32 RayTracingPipelineShaderGroupHandleCaptureReplay;
    public VkBool32 RayTracingPipelineShaderGroupHandleCaptureReplayMixed;
    public VkBool32 RayTracingPipelineTraceRaysIndirect;
    public VkBool32 RayTraversalPrimitiveCulling;
}