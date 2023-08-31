using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineIndirectDeviceAddressInfoNV
{
    public VkStructureType sType;
    public void* pNext;
    public VkPipelineBindPoint pipelineBindPoint;
    public VkPipeline pipeline;

    public VkPipelineIndirectDeviceAddressInfoNV()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_INDIRECT_DEVICE_ADDRESS_INFO_NV;
    }
}