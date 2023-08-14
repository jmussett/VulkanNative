using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCommandBufferInheritanceViewportScissorInfoNV
{
    public VkStructureType SType;
    public void* PNext;
    public VkBool32 ViewportScissor2D;
    public uint ViewportDepthCount;
    public VkViewport* PViewportDepths;
}