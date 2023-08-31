using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkRenderPassTransformBeginInfoQCOM
{
    public VkStructureType sType;
    public void* pNext;
    public VkSurfaceTransformFlagsKHR transform;
}