using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkScreenSurfaceCreateInfoQNX
{
    public VkStructureType sType;
    public void* pNext;
    public VkScreenSurfaceCreateFlagsQNX flags;
    public nint* context;
    public nint* window;

    public VkScreenSurfaceCreateInfoQNX()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_SCREEN_SURFACE_CREATE_INFO_QNX;
    }
}