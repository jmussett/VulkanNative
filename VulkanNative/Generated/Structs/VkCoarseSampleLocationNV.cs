using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCoarseSampleLocationNV
{
    public uint PixelX;
    public uint PixelY;
    public uint Sample;
}