using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkComponentMapping
{
    public VkComponentSwizzle r;
    public VkComponentSwizzle g;
    public VkComponentSwizzle b;
    public VkComponentSwizzle a;
}