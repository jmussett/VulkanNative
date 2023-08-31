using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Explicit)]
public unsafe struct VkPerformanceValueDataINTEL
{
    [FieldOffset(0)]
    public uint value32;
    [FieldOffset(0)]
    public ulong value64;
    [FieldOffset(0)]
    public float valueFloat;
    [FieldOffset(0)]
    public VkBool32 valueBool;
    [FieldOffset(0)]
    public byte* valueString;
}