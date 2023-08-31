using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceRayTracingPipelinePropertiesKHR
{
    public VkStructureType sType;
    public void* pNext;
    public uint shaderGroupHandleSize;
    public uint maxRayRecursionDepth;
    public uint maxShaderGroupStride;
    public uint shaderGroupBaseAlignment;
    public uint shaderGroupHandleCaptureReplaySize;
    public uint maxRayDispatchInvocationCount;
    public uint shaderGroupHandleAlignment;
    public uint maxRayHitAttributeSize;

    public VkPhysicalDeviceRayTracingPipelinePropertiesKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_PIPELINE_PROPERTIES_KHR;
    }
}