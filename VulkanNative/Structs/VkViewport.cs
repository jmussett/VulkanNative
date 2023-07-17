using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkViewport
{
    public float x;
    public float y;
    public float width;
    public float height;
    public float minDepth;
    public float maxDepth;
}