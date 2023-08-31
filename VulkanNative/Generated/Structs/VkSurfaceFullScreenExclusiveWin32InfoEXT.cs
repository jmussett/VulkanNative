using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSurfaceFullScreenExclusiveWin32InfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public nint hmonitor;
}