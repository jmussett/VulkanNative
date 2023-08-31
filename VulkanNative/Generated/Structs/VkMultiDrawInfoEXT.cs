using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkMultiDrawInfoEXT
{
    public uint firstVertex;
    public uint vertexCount;
}