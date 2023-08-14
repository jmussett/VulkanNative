using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSurfaceFormat2KHR
{
    public VkStructureType SType;
    public void* PNext;
    public VkSurfaceFormatKHR SurfaceFormat;
}