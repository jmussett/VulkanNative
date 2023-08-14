using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkWin32SurfaceCreateInfoKHR
{
    public VkStructureType SType;
    public void* PNext;
    public VkWin32SurfaceCreateFlagsKHR Flags;
    public nint Hinstance;
    public nint Hwnd;
}