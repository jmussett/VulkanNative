using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Explicit)]
public unsafe struct VkClearColorValue
{
    [FieldOffset(0)]
    public fixed float float32[4];
    [FieldOffset(0)]
    public fixed int int32[4];
    [FieldOffset(0)]
    public fixed uint uint32[4];
}