using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkRayTracingPipelineInterfaceCreateInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public uint maxPipelineRayPayloadSize;
    public uint maxPipelineRayHitAttributeSize;

    public VkRayTracingPipelineInterfaceCreateInfoKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_RAY_TRACING_PIPELINE_INTERFACE_CREATE_INFO_KHR;
    }
}