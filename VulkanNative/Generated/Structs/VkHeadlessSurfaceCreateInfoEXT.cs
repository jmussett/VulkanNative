using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkHeadlessSurfaceCreateInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkHeadlessSurfaceCreateFlagsEXT flags;

    public VkHeadlessSurfaceCreateInfoEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_HEADLESS_SURFACE_CREATE_INFO_EXT;
    }
}