using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkViSurfaceCreateInfoNN
{
    public VkStructureType sType;
    public void* pNext;
    public VkViSurfaceCreateFlagsNN flags;
    public void* window;
}