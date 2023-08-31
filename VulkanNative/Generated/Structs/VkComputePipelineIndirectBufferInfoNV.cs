using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkComputePipelineIndirectBufferInfoNV
{
    public VkStructureType sType;
    public void* pNext;
    public VkDeviceAddress deviceAddress;
    public VkDeviceSize size;
    public VkDeviceAddress pipelineDeviceAddressCaptureReplay;

    public VkComputePipelineIndirectBufferInfoNV()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_COMPUTE_PIPELINE_INDIRECT_BUFFER_INFO_NV;
    }
}