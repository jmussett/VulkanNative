using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSurfaceFullScreenExclusiveWin32InfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public nint hmonitor;

    public VkSurfaceFullScreenExclusiveWin32InfoEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_SURFACE_FULL_SCREEN_EXCLUSIVE_WIN32_INFO_EXT;
    }
}