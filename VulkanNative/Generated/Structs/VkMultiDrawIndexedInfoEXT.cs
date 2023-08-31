using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkMultiDrawIndexedInfoEXT
{
    public uint firstIndex;
    public uint indexCount;
    public int vertexOffset;
}