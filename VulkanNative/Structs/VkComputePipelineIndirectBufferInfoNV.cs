using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkComputePipelineIndirectBufferInfoNV
{
    public VkStructureType SType;
    public void* PNext;
    public VkDeviceAddress DeviceAddress;
    public VkDeviceSize Size;
    public VkDeviceAddress PipelineDeviceAddressCaptureReplay;
}