using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Explicit)]
public unsafe struct VkClearColorValue
{
    [FieldOffset(0)]
    public float float32;
    [FieldOffset(0)]
    public int int32;
    [FieldOffset(0)]
    public uint uint32;
}