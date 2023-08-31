using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkMetalSurfaceCreateInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkMetalSurfaceCreateFlagsEXT flags;
    public CAMetalLayer* pLayer;
}