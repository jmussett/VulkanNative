using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVertexInputAttributeDescription2EXT
{
    public VkStructureType SType;
    public void* PNext;
    public uint Location;
    public uint Binding;
    public VkFormat Format;
    public uint Offset;
}