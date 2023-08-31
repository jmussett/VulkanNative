using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Explicit)]
public unsafe struct VkPerformanceCounterResultKHR
{
    [FieldOffset(0)]
    public int int32;
    [FieldOffset(0)]
    public long int64;
    [FieldOffset(0)]
    public uint uint32;
    [FieldOffset(0)]
    public ulong uint64;
    [FieldOffset(0)]
    public float float32;
    [FieldOffset(0)]
    public double float64;
}