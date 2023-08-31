using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkMicromapTriangleEXT
{
    public uint dataOffset;
    public ushort subdivisionLevel;
    public ushort format;
}