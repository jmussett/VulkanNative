using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineIndirectDeviceAddressInfoNV
{
    public VkStructureType sType;
    public void* pNext;
    public VkPipelineBindPoint pipelineBindPoint;
    public VkPipeline pipeline;
}