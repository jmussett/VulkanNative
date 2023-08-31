using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkXlibSurfaceCreateInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkXlibSurfaceCreateFlagsKHR flags;
    public nint* dpy;
    public nint window;

    public VkXlibSurfaceCreateInfoKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_XLIB_SURFACE_CREATE_INFO_KHR;
    }
}