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
}