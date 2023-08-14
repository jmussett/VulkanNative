using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkComponentMapping
{
    public VkComponentSwizzle R;
    public VkComponentSwizzle G;
    public VkComponentSwizzle B;
    public VkComponentSwizzle A;
}