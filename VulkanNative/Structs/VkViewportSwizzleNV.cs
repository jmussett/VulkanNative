using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkViewportSwizzleNV
{
    public VkViewportCoordinateSwizzleNV X;
    public VkViewportCoordinateSwizzleNV Y;
    public VkViewportCoordinateSwizzleNV Z;
    public VkViewportCoordinateSwizzleNV W;
}