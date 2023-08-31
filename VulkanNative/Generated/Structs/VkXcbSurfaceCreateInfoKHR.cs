using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkXcbSurfaceCreateInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkXcbSurfaceCreateFlagsKHR flags;
    public nint* connection;
    public nint window;
}