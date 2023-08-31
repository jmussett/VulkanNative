using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkMicromapUsageEXT
{
    public uint count;
    public uint subdivisionLevel;
    public uint format;
}