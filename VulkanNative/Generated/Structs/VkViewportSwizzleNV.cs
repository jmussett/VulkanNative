using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkViewportSwizzleNV
{
    public VkViewportCoordinateSwizzleNV x;
    public VkViewportCoordinateSwizzleNV y;
    public VkViewportCoordinateSwizzleNV z;
    public VkViewportCoordinateSwizzleNV w;
}