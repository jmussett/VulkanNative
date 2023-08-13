using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkRayTracingPipelineInterfaceCreateInfoKHR
{
    public VkStructureType SType;
    public void* PNext;
    public uint MaxPipelineRayPayloadSize;
    public uint MaxPipelineRayHitAttributeSize;
}