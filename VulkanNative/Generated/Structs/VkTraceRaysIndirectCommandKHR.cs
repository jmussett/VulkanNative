using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkTraceRaysIndirectCommandKHR
{
    public uint Width;
    public uint Height;
    public uint Depth;
}