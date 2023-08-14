using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkMicromapUsageEXT
{
    public uint Count;
    public uint SubdivisionLevel;
    public uint Format;
}