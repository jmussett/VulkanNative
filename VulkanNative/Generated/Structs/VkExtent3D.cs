using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkExtent3D
{
    public uint width;
    public uint height;
    public uint depth;
}