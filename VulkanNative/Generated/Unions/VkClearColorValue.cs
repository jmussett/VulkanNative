using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Explicit)]
public unsafe struct VkClearColorValue
{
    [FieldOffset(0)]
    public fixed float Float32[4];
    [FieldOffset(0)]
    public fixed int Int32[4];
    [FieldOffset(0)]
    public fixed uint Uint32[4];
}