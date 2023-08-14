using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDirectFBSurfaceCreateInfoEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkDirectFBSurfaceCreateFlagsEXT Flags;
    public nint* Dfb;
    public nint* Surface;
}