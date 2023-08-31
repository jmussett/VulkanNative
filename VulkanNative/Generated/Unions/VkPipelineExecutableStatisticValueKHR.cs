using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Explicit)]
public unsafe struct VkPipelineExecutableStatisticValueKHR
{
    [FieldOffset(0)]
    public VkBool32 b32;
    [FieldOffset(0)]
    public long i64;
    [FieldOffset(0)]
    public ulong u64;
    [FieldOffset(0)]
    public double f64;
}