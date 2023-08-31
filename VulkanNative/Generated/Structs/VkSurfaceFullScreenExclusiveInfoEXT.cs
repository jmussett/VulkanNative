using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSurfaceFullScreenExclusiveInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkFullScreenExclusiveEXT fullScreenExclusive;
}