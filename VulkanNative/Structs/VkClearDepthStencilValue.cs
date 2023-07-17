using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkClearDepthStencilValue
{
    public float depth;
    public uint stencil;
}