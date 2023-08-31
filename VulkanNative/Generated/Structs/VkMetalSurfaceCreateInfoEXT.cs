using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkMetalSurfaceCreateInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkMetalSurfaceCreateFlagsEXT flags;
    public CAMetalLayer* pLayer;

    public VkMetalSurfaceCreateInfoEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_METAL_SURFACE_CREATE_INFO_EXT;
    }
}