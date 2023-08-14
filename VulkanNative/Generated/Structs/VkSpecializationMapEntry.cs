using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSpecializationMapEntry
{
    public uint ConstantID;
    public uint Offset;
    public nint Size;
}