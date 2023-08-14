using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDispatchIndirectCommand
{
    public uint X;
    public uint Y;
    public uint Z;
}