using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSurfaceFullScreenExclusiveInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkFullScreenExclusiveEXT fullScreenExclusive;

    public VkSurfaceFullScreenExclusiveInfoEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_SURFACE_FULL_SCREEN_EXCLUSIVE_INFO_EXT;
    }
}