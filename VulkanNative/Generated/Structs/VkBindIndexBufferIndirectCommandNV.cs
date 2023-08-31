using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkBindIndexBufferIndirectCommandNV
{
    public VkDeviceAddress bufferAddress;
    public uint size;
    public VkIndexType indexType;
}