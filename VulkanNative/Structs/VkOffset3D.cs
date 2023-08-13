using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkOffset3D
{
    public int X;
    public int Y;
    public int Z;
}