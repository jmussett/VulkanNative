using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkRect2D
{
    public VkOffset2D offset;
    public VkExtent2D extent;
}