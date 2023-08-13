using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDrawIndexedIndirectCommand
{
    public uint indexCount;
    public uint instanceCount;
    public uint firstIndex;
    public int vertexOffset;
    public uint firstInstance;
}