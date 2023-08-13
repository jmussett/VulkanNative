using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkHeadlessSurfaceCreateInfoEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkHeadlessSurfaceCreateFlagsEXT Flags;
}