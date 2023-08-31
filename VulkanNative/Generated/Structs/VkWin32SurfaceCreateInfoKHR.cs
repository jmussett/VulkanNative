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
}