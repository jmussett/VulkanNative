using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCopyCommandTransformInfoQCOM
{
    public VkStructureType SType;
    public void* PNext;
    public VkSurfaceTransformFlagsKHR Transform;
}