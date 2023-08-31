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
}