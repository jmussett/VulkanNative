using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSurfaceFullScreenExclusiveWin32InfoEXT
{
    public VkStructureType SType;
    public void* PNext;
    public nint Hmonitor;
}