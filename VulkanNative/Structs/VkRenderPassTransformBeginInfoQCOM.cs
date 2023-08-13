using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkRenderPassTransformBeginInfoQCOM
{
    public VkStructureType SType;
    public void* PNext;
    public VkSurfaceTransformFlagsKHR Transform;
}