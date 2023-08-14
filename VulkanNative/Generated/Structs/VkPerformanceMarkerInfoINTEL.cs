using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPerformanceMarkerInfoINTEL
{
    public VkStructureType SType;
    public void* PNext;
    public ulong Marker;
}