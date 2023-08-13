using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkWaylandSurfaceCreateInfoKHR
{
    public VkStructureType SType;
    public void* PNext;
    public VkWaylandSurfaceCreateFlagsKHR Flags;
    public nint* Display;
    public nint* Surface;
}