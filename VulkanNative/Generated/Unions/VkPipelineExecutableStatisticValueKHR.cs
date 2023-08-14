using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Explicit)]
public unsafe struct VkPipelineExecutableStatisticValueKHR
{
    [FieldOffset(0)]
    public VkBool32 B32;
    [FieldOffset(0)]
    public long I64;
    [FieldOffset(0)]
    public ulong U64;
    [FieldOffset(0)]
    public double F64;
}