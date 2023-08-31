using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDispatchIndirectCommand
{
    public uint x;
    public uint y;
    public uint z;
}