using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVertexInputAttributeDescription
{
    public uint Location;
    public uint Binding;
    public VkFormat Format;
    public uint Offset;
}