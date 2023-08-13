using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkXlibSurfaceCreateInfoKHR
{
    public VkStructureType SType;
    public void* PNext;
    public VkXlibSurfaceCreateFlagsKHR Flags;
    public nint* Dpy;
    public nint Window;
}