using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkMetalSurfaceCreateInfoEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkMetalSurfaceCreateFlagsEXT Flags;
    public CAMetalLayer* PLayer;
}