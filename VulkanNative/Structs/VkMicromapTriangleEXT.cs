using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkMicromapTriangleEXT
{
    public uint DataOffset;
    public ushort SubdivisionLevel;
    public ushort Format;
}