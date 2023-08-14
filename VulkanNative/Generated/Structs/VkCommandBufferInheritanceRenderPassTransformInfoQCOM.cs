using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCommandBufferInheritanceRenderPassTransformInfoQCOM
{
    public VkStructureType SType;
    public void* PNext;
    public VkSurfaceTransformFlagsKHR Transform;
    public VkRect2D RenderArea;
}