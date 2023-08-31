using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkWin32SurfaceCreateInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkWin32SurfaceCreateFlagsKHR flags;
    public nint hinstance;
    public nint hwnd;

    public VkWin32SurfaceCreateInfoKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_WIN32_SURFACE_CREATE_INFO_KHR;
    }
}