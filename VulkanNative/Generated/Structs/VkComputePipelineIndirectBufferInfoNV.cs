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
}