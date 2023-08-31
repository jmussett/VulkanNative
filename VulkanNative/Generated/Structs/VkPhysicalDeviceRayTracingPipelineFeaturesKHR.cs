using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceRayTracingPipelineFeaturesKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 rayTracingPipeline;
    public VkBool32 rayTracingPipelineShaderGroupHandleCaptureReplay;
    public VkBool32 rayTracingPipelineShaderGroupHandleCaptureReplayMixed;
    public VkBool32 rayTracingPipelineTraceRaysIndirect;
    public VkBool32 rayTraversalPrimitiveCulling;

    public VkPhysicalDeviceRayTracingPipelineFeaturesKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_PIPELINE_FEATURES_KHR;
    }
}