using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkRectLayerKHR
{
    public VkOffset2D Offset;
    public VkExtent2D Extent;
    public uint Layer;
}