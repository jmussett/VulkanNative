using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSpecializationMapEntry
{
    public uint constantID;
    public uint offset;
    public nint size;
}