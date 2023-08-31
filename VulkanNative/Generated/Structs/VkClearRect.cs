using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkClearRect
{
    public VkRect2D rect;
    public uint baseArrayLayer;
    public uint layerCount;
}