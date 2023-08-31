using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkOffset3D
{
    public int x;
    public int y;
    public int z;
}