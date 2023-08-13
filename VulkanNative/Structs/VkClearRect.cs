using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkClearRect
{
    public VkRect2D Rect;
    public uint BaseArrayLayer;
    public uint LayerCount;
}