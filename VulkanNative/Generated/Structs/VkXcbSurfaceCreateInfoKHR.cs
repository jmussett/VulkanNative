using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkXcbSurfaceCreateInfoKHR
{
    public VkStructureType SType;
    public void* PNext;
    public VkXcbSurfaceCreateFlagsKHR Flags;
    public nint* Connection;
    public nint Window;
}