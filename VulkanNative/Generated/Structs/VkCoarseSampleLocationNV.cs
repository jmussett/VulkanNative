using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCoarseSampleLocationNV
{
    public uint pixelX;
    public uint pixelY;
    public uint sample;
}