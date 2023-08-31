using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkWaylandSurfaceCreateInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkWaylandSurfaceCreateFlagsKHR flags;
    public nint* display;
    public nint* surface;
}