using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDisplaySurfaceCreateInfoKHR
{
    public VkStructureType SType;
    public void* PNext;
    public VkDisplaySurfaceCreateFlagsKHR Flags;
    public VkDisplayModeKHR DisplayMode;
    public uint PlaneIndex;
    public uint PlaneStackIndex;
    public VkSurfaceTransformFlagsKHR Transform;
    public float GlobalAlpha;
    public VkDisplayPlaneAlphaFlagsKHR AlphaMode;
    public VkExtent2D ImageExtent;
}