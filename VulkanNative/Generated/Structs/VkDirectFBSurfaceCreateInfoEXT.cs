using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDirectFBSurfaceCreateInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkDirectFBSurfaceCreateFlagsEXT flags;
    public nint* dfb;
    public nint* surface;

    public VkDirectFBSurfaceCreateInfoEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_DIRECTFB_SURFACE_CREATE_INFO_EXT;
    }
}