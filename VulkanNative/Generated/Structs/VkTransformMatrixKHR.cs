using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkTransformMatrixKHR
{
    public fixed float Matrix[3];
}