using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineCacheHeaderVersionOne
{
    public uint headerSize;
    public VkPipelineCacheHeaderVersion headerVersion;
    public uint vendorID;
    public uint deviceID;
    public fixed byte pipelineCacheUUID[(int)VulkanApiConstants.VK_UUID_SIZE];
}