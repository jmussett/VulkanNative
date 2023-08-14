using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Explicit)]
public unsafe struct VkPerformanceCounterResultKHR
{
    [FieldOffset(0)]
    public int Int32;
    [FieldOffset(0)]
    public long Int64;
    [FieldOffset(0)]
    public uint Uint32;
    [FieldOffset(0)]
    public ulong Uint64;
    [FieldOffset(0)]
    public float Float32;
    [FieldOffset(0)]
    public double Float64;
}