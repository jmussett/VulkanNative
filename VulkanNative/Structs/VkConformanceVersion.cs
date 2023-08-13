using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkConformanceVersion
{
    public byte Major;
    public byte Minor;
    public byte Subminor;
    public byte Patch;
}