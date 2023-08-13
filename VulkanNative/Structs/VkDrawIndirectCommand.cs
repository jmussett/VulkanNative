using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDrawIndirectCommand
{
    public uint vertexCount;
    public uint instanceCount;
    public uint firstVertex;
    public uint firstInstance;
}