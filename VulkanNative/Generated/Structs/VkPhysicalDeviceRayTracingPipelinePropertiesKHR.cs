using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceRayTracingPipelinePropertiesKHR
{
    public VkStructureType SType;
    public void* PNext;
    public uint ShaderGroupHandleSize;
    public uint MaxRayRecursionDepth;
    public uint MaxShaderGroupStride;
    public uint ShaderGroupBaseAlignment;
    public uint ShaderGroupHandleCaptureReplaySize;
    public uint MaxRayDispatchInvocationCount;
    public uint ShaderGroupHandleAlignment;
    public uint MaxRayHitAttributeSize;
}