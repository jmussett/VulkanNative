using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDisplayPlaneInfo2KHR
{
    public VkStructureType SType;
    public void* PNext;
    public VkDisplayModeKHR Mode;
    public uint PlaneIndex;
}