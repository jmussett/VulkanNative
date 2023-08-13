using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkScreenSurfaceCreateInfoQNX
{
    public VkStructureType SType;
    public void* PNext;
    public VkScreenSurfaceCreateFlagsQNX Flags;
    public nint* Context;
    public nint* Window;
}