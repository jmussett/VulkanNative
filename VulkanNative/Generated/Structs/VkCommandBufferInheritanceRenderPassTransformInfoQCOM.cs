using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCommandBufferInheritanceRenderPassTransformInfoQCOM
{
    public VkStructureType sType;
    public void* pNext;
    public VkSurfaceTransformFlagsKHR transform;
    public VkRect2D renderArea;
}