using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkRayTracingPipelineInterfaceCreateInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public uint maxPipelineRayPayloadSize;
    public uint maxPipelineRayHitAttributeSize;
}