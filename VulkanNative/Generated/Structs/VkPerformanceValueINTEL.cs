using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPerformanceValueINTEL
{
    public VkPerformanceValueTypeINTEL type;
    public VkPerformanceValueDataINTEL data;
}