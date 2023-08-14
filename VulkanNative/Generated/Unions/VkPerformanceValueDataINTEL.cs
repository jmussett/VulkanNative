using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Explicit)]
public unsafe struct VkPerformanceValueDataINTEL
{
    [FieldOffset(0)]
    public uint Value32;
    [FieldOffset(0)]
    public ulong Value64;
    [FieldOffset(0)]
    public float ValueFloat;
    [FieldOffset(0)]
    public VkBool32 ValueBool;
    [FieldOffset(0)]
    public char* ValueString;
}