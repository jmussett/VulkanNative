using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCommandBufferInheritanceViewportScissorInfoNV
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 viewportScissor2D;
    public uint viewportDepthCount;
    public VkViewport* pViewportDepths;
}