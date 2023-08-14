using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSurfaceFullScreenExclusiveInfoEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkFullScreenExclusiveEXT FullScreenExclusive;
}