using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineCacheHeaderVersionOne
{
    public uint HeaderSize;
    public VkPipelineCacheHeaderVersion HeaderVersion;
    public uint VendorID;
    public uint DeviceID;
    public fixed byte PipelineCacheUUID[(int)VulkanApiConstants.VK_UUID_SIZE];
}