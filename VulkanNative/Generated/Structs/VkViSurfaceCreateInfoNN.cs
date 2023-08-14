using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkViSurfaceCreateInfoNN
{
    public VkStructureType SType;
    public void* PNext;
    public VkViSurfaceCreateFlagsNN Flags;
    public void* Window;
}