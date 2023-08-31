using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkTraceRaysIndirectCommandKHR
{
    public uint width;
    public uint height;
    public uint depth;
}