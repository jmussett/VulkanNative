using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineIndirectDeviceAddressInfoNV
{
    public VkStructureType SType;
    public void* PNext;
    public VkPipelineBindPoint PipelineBindPoint;
    public VkPipeline Pipeline;
}