using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkBindVertexBufferIndirectCommandNV
{
    public VkDeviceAddress BufferAddress;
    public uint Size;
    public uint Stride;
}