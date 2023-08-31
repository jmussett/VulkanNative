using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkRectLayerKHR
{
    public VkOffset2D offset;
    public VkExtent2D extent;
    public uint layer;
}